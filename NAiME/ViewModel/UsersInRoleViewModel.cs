﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAiME.ViewModel
{
    public class UsersInRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string LastLogin { get; set; }
    }
}