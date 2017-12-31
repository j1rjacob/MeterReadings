using System;

namespace TMF.Core.Model
{
    [Serializable]
    public class UserInfo : ModelInfo
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public bool IsDelete { get; set; }
        public bool IsLock { get; set; }
        public string CreatedBy { get; set; } 
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }
        public int LockCount { get; set; }
        public string Remark { get; set; }
        public bool IsLogin { get; set; }
        public bool IsActive { get; set; }

        public UserInfo()
        {
            this.Id = -1L;
            this.UserId = "";
            this.Password = "";
            this.Name = "";
            this.Email = "";
            this.Company = "";
            this.IsDelete = false;
            this.IsLock = false;
            this.CreatedBy = "1";
            this.DateCreated = DateTime.Today;
            this.ModifiedBy = "1";
            this.DateModified = DateTime.Today;
            this.LockCount = 0;
            this.Remark = "";
            this.IsLogin = false;
            this.IsActive = false;
        }

        public UserInfo(long id, string userId, string password, string name, int roleId, string email, string company, int? languageId, bool isDelete, bool isLock, string createdBy, DateTime dateCreated, string modifiedBy, DateTime dateModified, int lockCount, string remark, bool isLogin, bool isActive, string title, string office, string manager, long? managerId)
        {
            this.Id = id;
            this.UserId = userId;
            this.Password = password;
            this.Name = name;
            this.Email = email;
            this.Company = company;
            this.IsDelete = isDelete;
            this.IsLock = isLock;
            this.CreatedBy = createdBy;
            this.DateCreated = dateCreated;
            this.ModifiedBy = modifiedBy;
            this.DateModified = dateModified;
            this.LockCount = lockCount;
            this.Remark = remark;
            this.IsLogin = isLogin;
            this.IsActive = isActive;
        }

        protected override void OnSetValue(string fieldname, object value)
        {
            string text = fieldname.ToLower();

            switch (fieldname.ToLower())
            {
                case "isactive":
                    this.IsActive = (value != null && Convert.ToBoolean(value)); 
                    break;
                case "userid":
                    this.UserId = ((value == null) ? "" : value.ToString()); 
                    break;
                case "modifiedby":
                    this.ModifiedBy = ((value == null) ? "" : value.ToString());
                    break;
                case "createdby":
                    this.CreatedBy = ((value == null) ? "" : value.ToString());
                    break;
                case "editedby":
                    this.Password = ((value == null) ? "" : value.ToString());
                    break;
                case "islogin":
                    this.IsLogin = (value != null && Convert.ToBoolean(value));
                    break;
                case "email":
                    this.Email = ((value == null) ? "" : value.ToString());
                    break;
                case "datemodified":
                    this.DateModified = ((value == null) ? DateTime.Today : Convert.ToDateTime(value));
                    break;
                case "lockcount":
                    this.LockCount = ((value == null) ? 1 : Convert.ToInt32(value));
                    break;
                case "name":
                    this.Name = ((value == null) ? "" : value.ToString());
                    break;
                case "remark":
                    this.Remark = ((value == null) ? "" : value.ToString());
                    break;
                case "datecreated":
                    this.Remark = ((value == null) ? "" : value.ToString());
                    break;
                case "islock":
                    this.IsLock = (value != null && Convert.ToBoolean(value));
                    break;
                case "isdelete":
                    this.IsDelete = (value != null && Convert.ToBoolean(value));
                    break;
                default:
                    //null;
                    break;
            }
        }  
               
           

        protected override object OnGetValue(string fieldname)
        {
            string text = fieldname.ToLower();

            switch (fieldname.ToLower())
            {
                case "isactive":
                    return this.IsActive;
                    break;
                case "userid":
                    return this.UserId;
                    break;
                case "modifiedby":
                    return this.ModifiedBy;
                    break;
                case "createdby":
                    return this.CreatedBy;
                    break;
                case "editedby":
                    return this.Password;
                    break;
                case "islogin":
                    return this.IsLogin;
                    break;
                case "email":
                    return this.Email;
                    break;
                case "datemodified":
                    return this.DateModified;
                    break;
                case "lockcount":
                    return LockCount;
                    break;
                case "name":
                    return Name;
                    break;
                case "remark":
                    return Remark;
                    break;
                case "datecreated":
                    return DateCreated;
                    break;
                case "islock":
                    this.IsLock = (value != null && Convert.ToBoolean(value));
                    break;
                case "isdelete":
                    this.IsDelete = (value != null && Convert.ToBoolean(value));
                    break;
                default:
                    return null;
                    break;
            }


            uint num = < PrivateImplementationDetails >.ComputeStringHash(text);
            object result;
            if (num <= 2324124615u)
            {
                if (num <= 926946562u)
                {
                    if (num <= 625445432u)
                    {
                        if (num != 279403738u)
                        {
                            if (num == 625445432u)
                            {
                                if (text == "is_active")
                                {
                                    result = this.IsActive;
                                    return result;
                                }
                            }
                        }
                        else if (text == "user_id")
                        {
                            result = this.UserId;
                            return result;
                        }
                    }
                    else if (num != 910909208u)
                    {
                        if (num != 926444256u)
                        {
                            if (num == 926946562u)
                            {
                                if (text == "modified_by")
                                {
                                    result = this.ModifiedBy;
                                    return result;
                                }
                            }
                        }
                        else if (text == "id")
                        {
                            result = this.Id;
                            return result;
                        }
                    }
                    else if (text == "password")
                    {
                        result = this.Password;
                        return result;
                    }
                }
                else if (num <= 1120211275u)
                {
                    if (num != 959716159u)
                    {
                        if (num != 991397836u)
                        {
                            if (num == 1120211275u)
                            {
                                if (text == "is_login")
                                {
                                    result = this.IsLogin;
                                    return result;
                                }
                            }
                        }
                    }
                }
                else if (num != 1513905545u)
                {
                    if (num != 1928175929u)
                    {
                        if (num == 2324124615u)
                        {
                            if (text == "email")
                            {
                                result = this.Email;
                                return result;
                            }
                        }
                    }
                    else if (text == "date_modified")
                    {
                        result = this.Date_Modified;
                        return result;
                    }
                }
                else if (text == "created_by")
                {
                    result = this.Created_By;
                    return result;
                }
            }
            else if (num <= 2861480497u)
            {
                if (num <= 2446189534u)
                {
                    if (num != 2369371622u)
                    {
                        if (num == 2446189534u)
                        {
                            if (text == "lock_count")
                            {
                                result = this.Lock_Count;
                                return result;
                            }
                        }
                    }
                    else if (text == "name")
                    {
                        result = this.Name;
                        return result;
                    }
                }
                else if (num != 2556802313u)
                {
                    if (num != 2858608828u)
                    {
                        if (num == 2861480497u)
                        {
                            if (text == "office")
                            {
                                result = this.Office;
                                return result;
                            }
                        }
                    }
                    else if (text == "company")
                    {
                        result = this.Company;
                        return result;
                    }
                }
                else if (text == "title")
                {
                    result = this.Title;
                    return result;
                }
            }
            else if (num <= 4098876561u)
            {
                if (num != 2962501081u)
                {
                    if (num != 3737921766u)
                    {
                        if (num == 4098876561u)
                        {
                            if (text == "remark")
                            {
                                result = this.Remark;
                                return result;
                            }
                        }
                    }
                    else if (text == "date_created")
                    {
                        result = this.Date_Created;
                        return result;
                    }
                }
                else if (text == "is_lock")
                {
                    result = this.Is_Lock;
                    return result;
                }
            }
            else if (num != 4159513505u)
            {
                if (num != 4173261164u)
                {
                    if (num == 4187677609u)
                    {
                        if (text == "is_delete")
                        {
                            result = this.Is_Delete;
                            return result;
                        }
                    }
                }
                else if (text == "manager_id")
                {
                    result = this.Manager_Id;
                    return result;
                }
            }
            else if (text == "language_id")
            {
                result = this.Language_Id;
                return result;
            }
            result = null;
            return result;
        }
    }
}
