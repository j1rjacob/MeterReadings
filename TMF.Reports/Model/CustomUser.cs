﻿using Microsoft.AspNet.Identity;

namespace TMF.Reports.Model
{
    public class CustomUser : IUser<int>
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Locked { get; set; }
    }
}
