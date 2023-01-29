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

        public IActionResult FindFriendsU()
        {
            return View("FindFriendsU");
            //Ссылка на страницу с посиском
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
            return View("ProfileU", dataDao2.RecordOprID(id));
        }
        public IActionResult EditUser(int id)
        {
            return View("UpdateUserU", dataDao2.UserInfo(id));
            // Ссылка на страницу редактуры
        }

        public IActionResult UpdateUser(User user)
        // Редактура
        {
            dataDao2.UpUserZn(user);
            return View("FriendsU");  
        }

        public IActionResult WarningU(int id)
        {
            // Добавление в БД*//*
            string nameAuthor = HttpContext.User.Identity.Name;
            int id_user = Convert.ToInt32(dataDao2.GetID(nameAuthor));
            dataDao2.GetWarning(id, id_user);
            return View("WarningU");
        }

        public ActionResult FriendsU()
        {
            return View("FriendsU"/*, dataDao2.ListFriends(false)*/);
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
