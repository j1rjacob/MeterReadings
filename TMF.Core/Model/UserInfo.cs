﻿using System;

namespace TMF.Core.Model
{
    [Serializable]
    public class UserInfo : ModelInfo
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }    
        public string SecurityQuestion { get; set; }    
        public string SecurityAnswer { get; set; }    
        public bool IsActive { get; set; }

        public UserInfo()
        {
            Id = "";
            Username = "";
            Password = null;
            Name = "";
            Role = "";
            SecurityQuestion = "";
            SecurityAnswer = "";
            IsActive = false;
        }

        public UserInfo(string id, string username, string name, string password, 
                        string role, string securityQuestion, string securityAnswer, 
                        bool isActive)
        {
            Id = id;
            Username = username;
            Password = password;
            Name = name;
            Role = role;
            SecurityQuestion = securityQuestion;
            SecurityAnswer = securityAnswer;
            IsActive = isActive;
        }

        protected override void OnSetValue(string fieldname, object value)
        {
            switch (fieldname.ToLower())
            {
                case "id":
                    Id = ((value == null) ? "" : value.ToString());
                    break;
                case "username":
                   Username = ((value == null) ? "" : value.ToString());
                    break;
                case "password":
                    Password = ((value == null) ? "" : value.ToString());
                    break;
                case "name":
                   Name = ((value == null) ? "" : value.ToString());
                    break;
                case "role":
                   Role = ((value == null) ? "" : value.ToString());
                    break;
                case "securityquestion":
                   SecurityQuestion = ((value == null) ? "" : value.ToString());
                    break;
                case "securityanswer":
                   SecurityAnswer = ((value == null) ? "" : value.ToString());
                    break;
                case "isactive":
                    IsActive = (value != null && Convert.ToBoolean(value)); 
                    break;
                default:
                    //null;
                    break;
            }
        }  

        protected override object OnGetValue(string fieldname)
        {
            switch (fieldname.ToLower())
            {
                case "id":
                    return Id;
                    break;
                case "username":
                    return Username;
                    break;
                case "password":
                    return Password;
                    break;
                case "name":
                    return Name;
                    break;
                case "role":
                    return Role;
                    break;
                case "securityquestion":
                    return SecurityQuestion;
                    break;
                case "securityanswer":
                    return SecurityAnswer;
                    break;
                case "isactive":
                    return IsActive;
                    break;
                default:
                    return null;
                    break;
            }
        }
    }
}
