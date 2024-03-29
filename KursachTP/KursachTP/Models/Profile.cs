﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KursachTP.Models
{
    public class Profile
    {
        public Profile(string f0, string f1, string f2, string f3, string f4, string f5, string f6)
        {
            Name = f0;
            LastName = f1;
            UserDescription = f2;
            Birthday = f3.Substring(0,11);
            Pol = Convert.ToBoolean(f4);
            UserID = Convert.ToString(f5);
            LinkMes = f6;
        }
        public Profile()
        {

        }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? UserDescription { get; set; }
        [Required]
        public string? Birthday { get; set;}
        [Required]
        public bool? Pol { get; set; }
        [Required]
        public string? UserID { get; set; }
        [Required]
        public string LinkMes { get; set; }
    }
    public static class Profiles
    {
        public static List<Profile> profiles = new List<Profile>();
    }
    public static class Hobbys
    {
        public static List<Hobby> hobbys = new List<Hobby>();
    }
}
