﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursachTP.Models;

namespace KursachTP.Models
{
    public class FindFriends
    {
        private int userID;
        public static int UserID
        {
            get
            {
                return User.UserID;
            }
            set
            {
                User.UserID = value;
            }
        }
        private string description;
        public static string Description
        {
            get
            {
                return User.Description;
            }
            set
            {
                User.Description = value;
            }
        }
        public static void SkipPerson()
        {
            //Console.WriteLine("Работает2");
        }
        public static void AddFriend()
        {
            //Console.WriteLine("Работает2");
        }
    }
}