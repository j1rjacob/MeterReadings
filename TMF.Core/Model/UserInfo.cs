using System;

namespace TMF.Core.Model
{
    [Serializable]
    public class UserInfo : ModelInfo
    {
        public long Id
        {
            get;
            set;
        }

        public string User_Id
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Role_Id
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Company
        {
            get;
            set;
        }

        public int? Language_Id
        {
            get;
            set;
        }

        public bool Is_Delete
        {
            get;
            set;
        }

        public bool Is_Lock
        {
            get;
            set;
        }

        public string Created_By
        {
            get;
            set;
        }

        public DateTime Date_Created
        {
            get;
            set;
        }

        public string Modified_By
        {
            get;
            set;
        }

        public DateTime Date_Modified
        {
            get;
            set;
        }

        public int Lock_Count
        {
            get;
            set;
        }

        public string Remark
        {
            get;
            set;
        }

        public bool Is_Login
        {
            get;
            set;
        }

        public bool Is_Active
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Office
        {
            get;
            set;
        }

        public string Manager
        {
            get;
            set;
        }

        public long? Manager_Id
        {
            get;
            set;
        }

        public UserInfo()
        {
            this.Id = -1L;
            this.User_Id = "";
            this.Password = "";
            this.Name = "";
            this.Role_Id = 0;
            this.Email = "";
            this.Company = "";
            this.Language_Id = new int?(0);
            this.Is_Delete = false;
            this.Is_Lock = false;
            this.Created_By = "1";
            this.Date_Created = DateTime.Today;
            this.Modified_By = "1";
            this.Date_Modified = DateTime.Today;
            this.Lock_Count = 0;
            this.Remark = "";
            this.Is_Login = false;
            this.Is_Active = false;
            this.Title = "";
            this.Office = "TMF";
            this.Manager = "";
        }

        public UserInfo(long id, string userId, string password, string name, int roleId, string email, string company, int? languageId, bool isDelete, bool isLock, string createdBy, DateTime dateCreated, string modifiedBy, DateTime dateModified, int lockCount, string remark, bool isLogin, bool isActive, string title, string office, string manager, long? managerId)
        {
            this.Id = id;
            this.User_Id = userId;
            this.Password = password;
            this.Name = name;
            this.Role_Id = roleId;
            this.Email = email;
            this.Company = company;
            this.Language_Id = languageId;
            this.Is_Delete = isDelete;
            this.Is_Lock = isLock;
            this.Created_By = createdBy;
            this.Date_Created = dateCreated;
            this.Modified_By = modifiedBy;
            this.Date_Modified = dateModified;
            this.Lock_Count = lockCount;
            this.Remark = remark;
            this.Is_Login = isLogin;
            this.Is_Active = isActive;
            this.Title = title;
            this.Office = office;
            this.Manager = manager;
            this.Manager_Id = managerId;
        }

        //protected override void OnSetValue(string fieldname, object value)
        //{
        //    string text = fieldname.ToLower();
        //    uint num = < PrivateImplementationDetails >.ComputeStringHash(text);
        //    if (num <= 2324124615u)
        //    {
        //        if (num <= 926946562u)
        //        {
        //            if (num <= 625445432u)
        //            {
        //                if (num != 279403738u)
        //                {
        //                    if (num == 625445432u)
        //                    {
        //                        if (text == "is_active")
        //                        {
        //                            this.Is_Active = (value != null && Convert.ToBoolean(value));
        //                        }
        //                    }
        //                }
        //                else if (text == "user_id")
        //                {
        //                    this.User_Id = ((value == null) ? "" : value.ToString());
        //                }
        //            }
        //            else if (num != 910909208u)
        //            {
        //                if (num != 926444256u)
        //                {
        //                    if (num == 926946562u)
        //                    {
        //                        if (text == "modified_by")
        //                        {
        //                            this.Modified_By = ((value == null) ? "" : value.ToString());
        //                        }
        //                    }
        //                }
        //                else if (text == "id")
        //                {
        //                    this.Id = Convert.ToInt64(value);
        //                }
        //            }
        //            else if (text == "password")
        //            {
        //                this.Password = ((value == null) ? "" : value.ToString());
        //            }
        //        }
        //        else if (num <= 1120211275u)
        //        {
        //            if (num != 959716159u)
        //            {
        //                if (num != 991397836u)
        //                {
        //                    if (num == 1120211275u)
        //                    {
        //                        if (text == "is_login")
        //                        {
        //                            this.Is_Login = (value != null && Convert.ToBoolean(value));
        //                        }
        //                    }
        //                }
        //                else if (text == "manager")
        //                {
        //                    this.Manager = ((value == null) ? "" : value.ToString());
        //                }
        //            }
        //            else if (text == "role_id")
        //            {
        //                this.Role_Id = Convert.ToInt32(value);
        //            }
        //        }
        //        else if (num != 1513905545u)
        //        {
        //            if (num != 1928175929u)
        //            {
        //                if (num == 2324124615u)
        //                {
        //                    if (text == "email")
        //                    {
        //                        this.Email = ((value == null) ? "" : value.ToString());
        //                    }
        //                }
        //            }
        //            else if (text == "date_modified")
        //            {
        //                this.Date_Modified = ((value == null) ? DateTime.Today : Convert.ToDateTime(value));
        //            }
        //        }
        //        else if (text == "created_by")
        //        {
        //            this.Created_By = ((value == null) ? "" : value.ToString());
        //        }
        //    }
        //    else if (num <= 2861480497u)
        //    {
        //        if (num <= 2446189534u)
        //        {
        //            if (num != 2369371622u)
        //            {
        //                if (num == 2446189534u)
        //                {
        //                    if (text == "lock_count")
        //                    {
        //                        this.Lock_Count = ((value == null) ? 1 : Convert.ToInt32(value));
        //                    }
        //                }
        //            }
        //            else if (text == "name")
        //            {
        //                this.Name = ((value == null) ? "" : value.ToString());
        //            }
        //        }
        //        else if (num != 2556802313u)
        //        {
        //            if (num != 2858608828u)
        //            {
        //                if (num == 2861480497u)
        //                {
        //                    if (text == "office")
        //                    {
        //                        this.Office = ((value == null) ? "" : value.ToString());
        //                    }
        //                }
        //            }
        //            else if (text == "company")
        //            {
        //                this.Company = ((value == null) ? "" : value.ToString());
        //            }
        //        }
        //        else if (text == "title")
        //        {
        //            this.Title = ((value == null) ? "" : value.ToString());
        //        }
        //    }
        //    else if (num <= 4098876561u)
        //    {
        //        if (num != 2962501081u)
        //        {
        //            if (num != 3737921766u)
        //            {
        //                if (num == 4098876561u)
        //                {
        //                    if (text == "remark")
        //                    {
        //                        this.Remark = ((value == null) ? "" : value.ToString());
        //                    }
        //                }
        //            }
        //            else if (text == "date_created")
        //            {
        //                this.Date_Created = ((value == null) ? DateTime.Today : Convert.ToDateTime(value));
        //            }
        //        }
        //        else if (text == "is_lock")
        //        {
        //            this.Is_Lock = (value != null && Convert.ToBoolean(value));
        //        }
        //    }
        //    else if (num != 4159513505u)
        //    {
        //        if (num != 4173261164u)
        //        {
        //            if (num == 4187677609u)
        //            {
        //                if (text == "is_delete")
        //                {
        //                    this.Is_Delete = (value != null && Convert.ToBoolean(value));
        //                }
        //            }
        //        }
        //        else if (text == "manager_id")
        //        {
        //            this.Manager_Id = CastDBNull.To<long?>(value, null);
        //        }
        //    }
        //    else if (text == "language_id")
        //    {
        //        this.Language_Id = CastDBNull.To<int?>(value, null);
        //    }
        //}

        //protected override object OnGetValue(string fieldname)
        //{
        //    string text = fieldname.ToLower();
        //    uint num = < PrivateImplementationDetails >.ComputeStringHash(text);
        //    object result;
        //    if (num <= 2324124615u)
        //    {
        //        if (num <= 926946562u)
        //        {
        //            if (num <= 625445432u)
        //            {
        //                if (num != 279403738u)
        //                {
        //                    if (num == 625445432u)
        //                    {
        //                        if (text == "is_active")
        //                        {
        //                            result = this.Is_Active;
        //                            return result;
        //                        }
        //                    }
        //                }
        //                else if (text == "user_id")
        //                {
        //                    result = this.User_Id;
        //                    return result;
        //                }
        //            }
        //            else if (num != 910909208u)
        //            {
        //                if (num != 926444256u)
        //                {
        //                    if (num == 926946562u)
        //                    {
        //                        if (text == "modified_by")
        //                        {
        //                            result = this.Modified_By;
        //                            return result;
        //                        }
        //                    }
        //                }
        //                else if (text == "id")
        //                {
        //                    result = this.Id;
        //                    return result;
        //                }
        //            }
        //            else if (text == "password")
        //            {
        //                result = this.Password;
        //                return result;
        //            }
        //        }
        //        else if (num <= 1120211275u)
        //        {
        //            if (num != 959716159u)
        //            {
        //                if (num != 991397836u)
        //                {
        //                    if (num == 1120211275u)
        //                    {
        //                        if (text == "is_login")
        //                        {
        //                            result = this.Is_Login;
        //                            return result;
        //                        }
        //                    }
        //                }
        //                else if (text == "manager")
        //                {
        //                    result = this.Manager;
        //                    return result;
        //                }
        //            }
        //            else if (text == "role_id")
        //            {
        //                result = this.Role_Id;
        //                return result;
        //            }
        //        }
        //        else if (num != 1513905545u)
        //        {
        //            if (num != 1928175929u)
        //            {
        //                if (num == 2324124615u)
        //                {
        //                    if (text == "email")
        //                    {
        //                        result = this.Email;
        //                        return result;
        //                    }
        //                }
        //            }
        //            else if (text == "date_modified")
        //            {
        //                result = this.Date_Modified;
        //                return result;
        //            }
        //        }
        //        else if (text == "created_by")
        //        {
        //            result = this.Created_By;
        //            return result;
        //        }
        //    }
        //    else if (num <= 2861480497u)
        //    {
        //        if (num <= 2446189534u)
        //        {
        //            if (num != 2369371622u)
        //            {
        //                if (num == 2446189534u)
        //                {
        //                    if (text == "lock_count")
        //                    {
        //                        result = this.Lock_Count;
        //                        return result;
        //                    }
        //                }
        //            }
        //            else if (text == "name")
        //            {
        //                result = this.Name;
        //                return result;
        //            }
        //        }
        //        else if (num != 2556802313u)
        //        {
        //            if (num != 2858608828u)
        //            {
        //                if (num == 2861480497u)
        //                {
        //                    if (text == "office")
        //                    {
        //                        result = this.Office;
        //                        return result;
        //                    }
        //                }
        //            }
        //            else if (text == "company")
        //            {
        //                result = this.Company;
        //                return result;
        //            }
        //        }
        //        else if (text == "title")
        //        {
        //            result = this.Title;
        //            return result;
        //        }
        //    }
        //    else if (num <= 4098876561u)
        //    {
        //        if (num != 2962501081u)
        //        {
        //            if (num != 3737921766u)
        //            {
        //                if (num == 4098876561u)
        //                {
        //                    if (text == "remark")
        //                    {
        //                        result = this.Remark;
        //                        return result;
        //                    }
        //                }
        //            }
        //            else if (text == "date_created")
        //            {
        //                result = this.Date_Created;
        //                return result;
        //            }
        //        }
        //        else if (text == "is_lock")
        //        {
        //            result = this.Is_Lock;
        //            return result;
        //        }
        //    }
        //    else if (num != 4159513505u)
        //    {
        //        if (num != 4173261164u)
        //        {
        //            if (num == 4187677609u)
        //            {
        //                if (text == "is_delete")
        //                {
        //                    result = this.Is_Delete;
        //                    return result;
        //                }
        //            }
        //        }
        //        else if (text == "manager_id")
        //        {
        //            result = this.Manager_Id;
        //            return result;
        //        }
        //    }
        //    else if (text == "language_id")
        //    {
        //        result = this.Language_Id;
        //        return result;
        //    }
        //    result = null;
        //    return result;
        //}
    }
}
