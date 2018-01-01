using System.Collections.Generic;
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
            bool flag = info.UserId.Trim().Length < 5;
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.InvalidInput, "User Id too short! Minimum 6 characters.");
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
            bool flag = string.IsNullOrEmpty(info.UserId);
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.NullReference, "User Id is required");
            }
            else
            {
                bool flag2 = info.UserId.Trim().Length < 5;
                if (flag2)
                {
                    result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid User Id");
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

        public ReturnInfo UpdateLoginStatus(SmartDB dbInstance, string userId, bool isLogin)
        {
            bool flag = string.IsNullOrEmpty(userId);
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.NullReference, "User Id is required");
            }
            else
            {
                bool flag2 = userId.Trim().Length < 5;
                if (flag2)
                {
                    result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid User ID");
                }
                else
                {
                    IInfo info = UserInfoBLL.dal.UpdateLoginStatus(dbInstance, userId, isLogin);
                    result = new ReturnInfo(info.Code, info.Message, info.RowsAffected);
                }
            }
            return result;
        }

        public ReturnInfo Delete(SmartDB dbInstance, long Id)
        {
            bool flag = Id <= 0L;
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

        public ReturnInfo GetUserById(SmartDB dbInstance, long Id, out UserInfo info)
        {
            IInfo record = UserInfoBLL.dal.GetRecord(dbInstance, Id, out info);
            bool flag = record.Code > ErrorEnum.NoError;
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(record.Code, record.Message);
            }
            else
            {
                result = new ReturnInfo();
            }
            return result;
        }

        public ReturnInfo GetUserList(SmartDB dbInstance, out List<UserInfo> list)
        {
            list = new List<UserInfo>();
            IInfo records = UserInfoBLL.dal.GetRecords(dbInstance, out list);
            bool flag = records.Code > ErrorEnum.NoError;
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(records.Code, records.Message);
            }
            else
            {
                result = new ReturnInfo();
            }
            return result;
        }
    }
}
