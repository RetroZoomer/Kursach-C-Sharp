﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachTP.Controllers;
using KursachTP.DAO;
using KursachTP.Models;

namespace KursachTP.Controllers
{
    public class UserController : Controller
    {
        WorkDAO dataDao2 = new WorkDAO();
        // GET: UserController
        public ActionResult PostViewU()
        { // Посты для пользователя
            return View("PostViewU", dataDao2.ListPost(false));
        }
        public IActionResult NewPostU(Post post)
        {
            //Создание нового поста
            string nameAuthor = HttpContext.User.Identity.Name;
            int id = Convert.ToInt32(dataDao2.GetID(nameAuthor));
            dataDao2.GetPost(post, id);
            return View("PostViewU", dataDao2.ListPost(true));
        }

        public IActionResult CreatePostU(Post post)
        {
            return View("InsertPostU", post);
            //Ссылка на создание нового поста
        }
        public IActionResult DeletePostU(int id)
        {
            dataDao2.DeleteByIdPost(id);
            return View("PostViewU", dataDao2.ListPost(true));
            //Удаление поста
        }
        public IActionResult EditPostU(int id)
        {
            return View("UpdatePostU", dataDao2.PostInfo(id));
            // Ссылка на страницу редактуры
        }

        public IActionResult UpdatePostU(Post post)
        // Редактура
        {
            dataDao2.UpPostU(post);
            return View("PostViewU", dataDao2.ListPost(true));
        }

        public IActionResult ProfileU()
        {
            //Страница профиля
            //static ClaimsPrincipal.FindFirst(string);
            string namesuser = HttpContext.User.Identity.Name;
            return View("ProfileU", dataDao2.RecordOprName(namesuser));
        }
        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public IActionResult AnotherUser(int id)
        {
            //Страница профиля
            return View("ProfileFr", dataDao2.RecordOprID(id));
        }
        public IActionResult NewFriend(int id)
        {
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao2.GetID(nameAuthor));
            dataDao2.GetFr(id_user, id);
            return View("ProfileFr", dataDao2.RecordOprID(id));
        }
        public IActionResult EditUser(int id)
        {            // Ссылка на страницу редактуры
            return View("UpdateUserU", dataDao2.UserInfo(id));
        }

        public IActionResult FindFriendsU()
        {
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao2.GetID(nameAuthor));
            return View("FindFriendsU", dataDao2.ListFriends(id_user,null,false));
            //Ссылка на страницу с поиском
        }
        public IActionResult DeleteFriend(int id)
        {
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao2.GetID(nameAuthor));
            dataDao2.DeleteFriendID(id,id_user);
            return View("FindFriendsU", dataDao2.ListFriends(id_user,null,false));
            //Удаление пользователя и возвращение ко всем пользователям
        }
        public IActionResult FriendName(string namesuser)
        {
            //Вывод друзей по имени/логину
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao2.GetID(nameAuthor));
            return View("FindFriendsU", dataDao2.ListFriends(id_user, namesuser,true));
        }
        
        public IActionResult WarningU(int id, Warning warning)
        {
            // Добавление в БД*//*
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao2.GetID(nameAuthor));
            dataDao2.GetWarning(id, id_user, warning.WarningDescription);
            return View("PostViewU", dataDao2.ListPost(false));
        }

        public ActionResult FriendsU()
        { // Вывод друзей
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao2.GetID(nameAuthor));
            return View("FriendsU", dataDao2.ListFriends(id_user,null,true));
        }
        public IActionResult UpdateUser(User user)
        // Редактура
        {
            dataDao2.UpUserZn(user);
            return View("ProfileU", dataDao2.RecordOprID(user.UserID));
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
