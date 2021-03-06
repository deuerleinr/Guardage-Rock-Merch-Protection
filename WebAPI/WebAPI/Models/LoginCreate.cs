﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class LoginCreate
    {
        [Required]
        public string Email { get; set; }
        public string PasswordHash { get; set; }       
        public bool IsAdmin { get; set; }
    }
}