﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using KursachTP.Models;
using Microsoft.Extensions.Logging;
using KursachTP.DAO;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace KursachTP.Controllers
{
    public class HomeController : Controller
    {
        WorkDAO dataDao = new WorkDAO();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Authorize(Policy = "OnlyForAdmin")]
        public IActionResult Index()
        { // Список пользователей
            return View(dataDao.Record(1,0,0,null));
        }
        public IActionResult StarterPage()
        {     // Стартовая страница
            return View("StarterPage");
        }

        public IActionResult NewPerson(User user)
        { //Создание нового пользователя
            dataDao.GetPerson(user);
            return View("StarterPage");
        }

        public IActionResult CreatePerson(User user)
        {  //Ссылка на создание нового пользователя
            return View("Register", user);
        }
        [Authorize(Policy ="OnlyForAdmin")]
        public IActionResult DeletePerson(int id)
        {
            dataDao.DeleteById(id);
            return View("Index", dataDao.Record(1, 0, 0, null));
            //Удаление пользователя
        }
        [Authorize]
        public IActionResult EditPerson(int id)
        {
            return View("UpdateUser", dataDao.UserInfo(id));
            // Ссылка на страницу редактуры
        }
        public IActionResult UpdatePerson(User user)
        // Редактура
        {
            dataDao.UpZn(user);
            return View("Index", dataDao.Record(1, 0, 0, null));
        }
        public IActionResult InfoPerson(int id)
        {
            // Подробный Вывод
            return View("InfoUserView", dataDao.UserInfo(id));
        }
        public IActionResult IndexID(int usersid, int usersid2)
        {
            //Вывод пользователей от определенного id
            return View("Index", dataDao.Record(2, usersid, usersid2, null));
        }
        public IActionResult IndexName(string namesuser)
        {
            //Вывод пользователей по имени
            return View("Index" , dataDao.Record(3,0,0,namesuser));
        }
        public IActionResult PostView()
        {
            //Страница постов
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao.GetID(nameAuthor));
            return View("PostView", dataDao.ListPost(true,false,id_user, 0));
        }
        public IActionResult PostViewFriends()
        {
            //Страница постов
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao.GetID(nameAuthor));
            return View("PostView", dataDao.ListPost(true,true, id_user, 0));
        }
        public IActionResult ProfileView()
        {
            //Страница профиля
            string namesuser = HttpContext.User.Identity.Name;
            return View("Profile", dataDao.RecordOprName(namesuser));
        }
        public IActionResult AnotherUser(int id)
        {
            //Страница профиля
            return View("Profile", dataDao.RecordOprID(id));
        }
        public IActionResult NewPost(Post post)
        {
            //Создание нового поста
            string nameAuthor = HttpContext.User.Identity.Name;
            int id = Convert.ToInt32(dataDao.GetID(nameAuthor));
            dataDao.GetPost(post,id);
            return View("PostView", dataDao.ListPost(true, false,id, 0));
        }
        public IActionResult CreatePost(Post post)
        {
            return View("InsertPost", post);
            //Ссылка на создание нового поста
        }
        public IActionResult DeletePost(int id)
        {
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao.GetID(nameAuthor));
            dataDao.DeleteByIdPost(id);
            return View("PostView", dataDao.ListPost(true, false, id_user, 0));
            //Удаление поста
        }
        public IActionResult EditPost(int id)
        {
            return View("UpdatePost", dataDao.PostInfo(id));
            // Ссылка на страницу редактуры
        }
        public IActionResult UpdatePost(Post post)
        // Редактура
        {
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao.GetID(nameAuthor));
            dataDao.UpPost(post);
            return View("PostView", dataDao.ListPost(true, false, id_user, 0));
        }
        public IActionResult InfoPost(int id)
        {
            // Подробный Вывод 
            return View("InfoPostView", dataDao.PostInfo(id));
        }
        public IActionResult InfoPostWarning(int id)
        {
            // Подробный Вывод 
            return View("InfoPostView", dataDao.PostInfo(id));
        }
        public IActionResult Zapas()
        {
            return View("Zapas");
        }
        public IActionResult WarningCount(int id)
        {
            // Подробный Вывод 
            return View("WarningView");
        }
        public IActionResult WarningView()
        {
            // Подробный Вывод 
            return View("WarningView", dataDao.ListWarning());
        }
        public IActionResult UnLogin()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return View("StarterPage");
        }
        public IActionResult Login(string returnURL)
        {
            ViewBag.ReturnURL = returnURL;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            if (dataDao.YesNoData(user))
            {
                 var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Login), 
                    new Claim(ClaimTypes.Locality, dataDao.GetRole(user))
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));
                if (dataDao.GetRole(user) == "AdminIS")
                {
                    return Redirect("/Home/Index");
                }
                else { return Redirect("/User/PostViewU"); }
            }
            else
            {
                return View("Login2");
            }
        }
    }
}
