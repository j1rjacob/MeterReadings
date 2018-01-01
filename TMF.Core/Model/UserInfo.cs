using System;

namespace TMF.Core.Model
{
    [Serializable]
    public class UserInfo : ModelInfo
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RoleId { get; set; }    
        public bool IsDelete { get; set; }
        public bool IsLock { get; set; }
        public string CreatedBy { get; set; } 
        public DateTime DateCreated { get; set; }
        public string EditedBy { get; set; }
        public DateTime DateEdited { get; set; }
        public int LockCount { get; set; }
        public string Remark { get; set; }
        public bool IsLogin { get; set; }
        public bool IsActive { get; set; }

        public UserInfo()
        {
            Id = "";
            UserId = "";
            Password = "";
            Name = "";
            Email = "";
            RoleId = "";
            IsDelete = false;
            IsLock = false;
            CreatedBy = "1";
            DateCreated = DateTime.Today;
            EditedBy = "1";
            DateEdited = DateTime.Today;
            LockCount = 0;
            Remark = "";
            IsLogin = false;
            IsActive = false;
        }

        public UserInfo(string id, string userId, string password, string name, string email, string roleId, bool isDelete, bool isLock, string createdBy, DateTime dateCreated, string editedBy, DateTime dateEdited, int lockCount, string remark, bool isLogin, bool isActive)
        {
            Id = id;
            UserId = userId;
            Password = password;
            Name = name;
            Email = email;
            RoleId = roleId;
            IsDelete = isDelete;
            IsLock = isLock;
            CreatedBy = createdBy;
            DateCreated = dateCreated;
            EditedBy = editedBy;
            DateEdited = dateEdited;
            LockCount = lockCount;
            Remark = remark;
            IsLogin = isLogin;
            IsActive = isActive;
        }

        protected override void OnSetValue(string fieldname, object value)
        {
            switch (fieldname.ToLower())
            {
                case "id":
                    Id = ((value == null) ? "" : value.ToString());
                    break;
                case "userid":
                   UserId = ((value == null) ? "" : value.ToString());
                    break;
                case "password":
                    Password = ((value == null) ? "" : value.ToString());
                    break;
                case "name":
                   Name = ((value == null) ? "" : value.ToString());
                    break;
                case "email":
                    Email = ((value == null) ? "" : value.ToString());
                    break;
                case "roleid":
                    RoleId = ((value == null) ? "" : value.ToString());
                    break;
                case "isdelete":
                    IsDelete = (value != null && Convert.ToBoolean(value));
                    break;
                case "islock":
                    IsLock = (value != null && Convert.ToBoolean(value));
                    break;
                case "createdby":
                    CreatedBy = ((value == null) ? "" : value.ToString());
                    break;
                case "datecreated":
                    Remark = ((value == null) ? "" : value.ToString());
                    break;
                case "editedby":
                    EditedBy = ((value == null) ? "" : value.ToString());
                    break;
                case "dateedited":
                    DateEdited = ((value == null) ? DateTime.Today : Convert.ToDateTime(value));
                    break;
                case "lockcount":
                    LockCount = ((value == null) ? 1 : Convert.ToInt32(value));
                    break;
                case "remark":
                    Remark = ((value == null) ? "" : value.ToString());
                    break;
                case "islogin":
                    IsLogin = (value != null && Convert.ToBoolean(value));
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
                case "userid":
                    return UserId;
                    break;
                case "password":
                    return Password;
                    break;
                case "name":
                    return Name;
                    break;
                case "email":
                    return Email;
                    break;
                case "roleid":
                    return RoleId;
                    break;
                case "isdelete":
                    return IsDelete;
                    break;
                case "islock":
                    return IsLock;
                    break;
                case "createdby":
                    return CreatedBy;
                    break;
                case "datecreated":
                    return DateCreated;
                    break;
                case "editedby":
                    return EditedBy;
                    break;
                case "dateedited":
                    return DateEdited;
                    break;
                case "lockcount":
                    return LockCount;
                    break;
                case "remark":
                    return Remark;
                    break;
                case "islogin":
                    return IsLogin;
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
