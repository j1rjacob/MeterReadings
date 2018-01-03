using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TMF.Core.DAL;
using TMF.Core.Model;

namespace TMF.Core
{
    public class UserInfoBLL : BusinessBase
    {
        private static readonly UserInfoDAL dal = new UserInfoDAL();
        public IInfo CheckRight()
        {
            return new ReturnInfo(ErrorEnum.NoError, "");
        }
        public ReturnInfo Create(SmartDB dbInstance, ref UserInfo info)
        {
            bool flag = info.Username.Trim().Length < 5;
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.InvalidInput, "Username too short! Minimum 6 characters.");
            }
            else
            {
                bool flag2 = info.Password.Trim().Length < 8;
                if (flag2)
                {
                    result = new ReturnInfo(ErrorEnum.InvalidInput, "Password too short! Minimum 8 characters.");
                }
                else
                {
                    bool flag3 = info.Name.Trim().Length < 8;
                    if (flag3)
                    {
                        result = new ReturnInfo(ErrorEnum.InvalidInput, "Name too short! Minimum 8 characters.");
                    }
                    else
                    {
                        IInfo info2 = UserInfoBLL.dal.Insert(dbInstance, ref info);
                        bool flag4 = info2.Code == ErrorEnum.NoError;
                        if (flag4)
                        {
                            result = new ReturnInfo(info2.Code, info2.Message);
                        }
                        else
                        {
                            result = new ReturnInfo(info2.Code, info2.Message);
                        }
                    }
                }
            }
            return result;
        }
        public ReturnInfo Update(SmartDB dbInstance, UserInfo info)
        {
            bool flag = string.IsNullOrEmpty(info.Username);
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.NullReference, "Username is required");
            }
            else
            {
                bool flag2 = info.Username.Trim().Length < 5;
                if (flag2)
                {
                    result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid Username");
                }
                else
                {
                    bool flag3 = string.IsNullOrEmpty(info.Password) || string.IsNullOrWhiteSpace(info.Password);
                    if (flag3)
                    {
                        result = new ReturnInfo(ErrorEnum.NullReference, "Password is required");
                    }
                    else
                    {
                        bool flag4 = info.Password.Length < 8;
                        if (flag4)
                        {
                            result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid Password");
                        }
                        else
                        {
                            bool flag5 = string.IsNullOrWhiteSpace(info.Name) || string.IsNullOrEmpty(info.Name);
                            if (flag5)
                            {
                                result = new ReturnInfo(ErrorEnum.NullReference, "Name is required");
                            }
                            else
                            {
                                IInfo info2 = UserInfoBLL.dal.Update(dbInstance, info);
                                result = new ReturnInfo(info2.Code, info2.Message, info2.RowsAffected);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public ReturnInfo UpdateLoginStatus(SmartDB dbInstance, string username, bool isActive)
        {
            bool flag = string.IsNullOrEmpty(username);
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.NullReference, "User Id is required");
            }
            else
            {
                bool flag2 = username.Trim().Length < 5;
                if (flag2)
                {
                    result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid User ID");
                }
                else
                {
                    IInfo info = UserInfoBLL.dal.UpdateLoginStatus(dbInstance, username, isActive);
                    result = new ReturnInfo(info.Code, info.Message, info.RowsAffected);
                }
            }
            return result;
        }
        public ReturnInfo Delete(SmartDB dbInstance, string Id)
        {
            bool flag = Id == "";
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid ID");
            }
            else
            {
                IInfo info = UserInfoBLL.dal.Delete(dbInstance, Id);
                result = new ReturnInfo(info.Code, info.Message, info.RowsAffected);
            }
            return result;
        }
        public ReturnInfo Remove(SmartDB dbInstance, long Id)
        {
            bool flag = Id <= 0L;
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid ID");
            }
            else
            {
                IInfo info = UserInfoBLL.dal.Remove(dbInstance, Id);
                result = new ReturnInfo(info.Code, info.Message, info.RowsAffected);
            }
            return result;
        }
        public ReturnInfo GetUserByUserId(SmartDB dbInstance, string UserId, out UserInfo info)
        {
            bool flag = string.IsNullOrEmpty(UserId);
            ReturnInfo result;
            if (flag)
            {
                info = null;
                result = new ReturnInfo(ErrorEnum.NullReference, "User Id is required");
            }
            else
            {
                IInfo record = UserInfoBLL.dal.GetRecord(dbInstance, UserId, out info);
                bool flag2 = record.Code > ErrorEnum.NoError;
                if (flag2)
                {
                    result = new ReturnInfo(record.Code, record.Message);
                }
                else
                {
                    result = new ReturnInfo();
                }
            }
            return result;
        }
        public ReturnInfo GetUserById(SmartDB dbInstance, string Id)
        {
            string sQL_GET = "REPORT USERINFO_GET_USER_ID";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@Id", SqlDbType.NVarChar)
            };
            array[0].Value = Id;
            IInfo record = UserInfoBLL.dal.GetRecord(dbInstance, sQL_GET, array);
            return new ReturnInfo
            {
                BizObject = ((record.Code == ErrorEnum.NoError) ? record.BizObject : null),
                Code = record.Code,
                Message = record.Message,
                RowsAffected = record.RowsAffected
            };
        }
        public ReturnInfo GetUserByUsernamePassword(SmartDB dbInstance, string username, string password)
        {
            string cmdText = "[REPORT USERINFO_USERNAME_PASSWORD]";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@Username", SqlDbType.NVarChar),
                new SqlParameter("@Password", SqlDbType.NVarChar)
            };
            array[0].Value = username;
            array[1].Value = password;
            IInfo records = UserInfoBLL.dal.GetRecords(dbInstance, cmdText, array);
            return new ReturnInfo
            {
                Code = records.Code,
                Message = records.Message,
                BizObject = ((records.Code == ErrorEnum.NoError) ? records.BizObject : new List<Model.UserInfo>())
            };
        }

        public ReturnInfo GetUsersByName(SmartDB dbInstance, string name)
        {
            string cmdText = "[REPORT USERINFO_NAME]";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@Name", SqlDbType.NVarChar)
            };
            array[0].Value = name;
            IInfo records = UserInfoBLL.dal.GetRecords(dbInstance, cmdText, array);
            return new ReturnInfo
            {
                Code = records.Code,
                Message = records.Message,
                BizObject = ((records.Code == ErrorEnum.NoError) ? records.BizObject : new List<UserInfo>())
            };
        }
        public ReturnInfo GetUserByUsername(SmartDB dbInstance, string username)
        {
            string sQL_GET = "REPORT USERINFO_USERNAME";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@Username", SqlDbType.NVarChar)
            };
            array[0].Value = username;
            IInfo record = UserInfoBLL.dal.GetRecord(dbInstance, sQL_GET, array);
            return new ReturnInfo
            {
                BizObject = ((record.Code == ErrorEnum.NoError) ? record.BizObject : null),
                Code = record.Code,
                Message = record.Message,
                RowsAffected = record.RowsAffected
            };
        }
        public ReturnInfo GetUserList(SmartDB dbInstance)
        {
            IInfo records = UserInfoBLL.dal.GetRecords(dbInstance, "REPORT USERINFO_LST", null);
            return new ReturnInfo
            {
                Code = records.Code,
                Message = records.Message,
                BizObject = ((records.Code == ErrorEnum.NoError) ? records.BizObject : new List<Model.UserInfo>())
            };
        }
    }
}
