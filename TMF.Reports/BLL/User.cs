﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.BLL
{
    public class User : BusinessBase
    {
        private static readonly DAL.User _dal = new DAL.User();

        private string lang = "en";
        public string Lang
        {
            get
            {
                return this.lang;
            }
            set
            {
                this.lang = value;
            }
        }
        public IInfo CheckRight()
        {
            return new ReturnInfo(ErrorEnum.NoError, "");
        }
        public ReturnInfo IsValid(Model.User info)
        {
            bool flag = info.Id == 0 ? false : true;
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo
                {
                    Code = ErrorEnum.InvalidInput,
                    Message = "Name cannot be blank.",
                    BizObject = "Name"
                };
            }
            else
            {
                result = new ReturnInfo(ErrorEnum.NoError, "");
            }
            return result;
        }
        //public ReturnInfo Create(SmartDB dbInstance, ref Model.User info)
        //{
        //    IInfo info2 = _dal.Insert(dbInstance, info);
        //    info.IsNew = false;
        //    info.IsDirty = true;
        //    return new ReturnInfo(info2.Code, info2.Message);
        //}
        //public ReturnInfo Update(SmartDB dbInstance, Model.User info)
        //{
        //    IInfo info2 = _dal.GetRecord(dbInstance, info.Id);
        //    bool flag = info2.Code == ErrorEnum.NoError;
        //    ReturnInfo result;
        //    if (flag)
        //    {
        //        bool flag2 = (info2.BizObject as Model.User).LockCount == info.LockCount;
        //        if (!flag2)
        //        {
        //            result = new ReturnInfo(ErrorEnum.ColumnReference, "Record has been changed.");
        //            return result;
        //        }
        //        info.LockCount++;
        //        info2 = _dal.Update(dbInstance, info);
        //    }
        //    result = new ReturnInfo(info2.Code, info2.Message, info2.RowsAffected);
        //    return result;
        //}
        //public ReturnInfo Delete(SmartDB dbInstance, string Id)
        //{
        //    bool flag = Id == null;
        //    ReturnInfo result;
        //    if (flag)
        //    {
        //        result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid input. ID not found.");
        //    }
        //    else
        //    {
        //        IInfo info = _dal.Delete(dbInstance, Id);
        //        result = new ReturnInfo(info.Code, info.Message, info.RowsAffected);
        //    }
        //    return result;
        //}
        public ReturnInfo GetUserById(SmartDB dbInstance, int Id)
        {
            IInfo record = _dal.GetRecord(dbInstance, Id);
            return new ReturnInfo
            {
                BizObject = ((record.Code == ErrorEnum.NoError) ? record.BizObject : null),
                Code = record.Code,
                Message = record.Message,
                RowsAffected = record.RowsAffected
            };
        }
        public ReturnInfo GetUserByDescription(SmartDB dbInstance, string Description)
        {
            IInfo record = _dal.GetRecordsByDescription(dbInstance, Description);
            return new ReturnInfo
            {
                BizObject = ((record.Code == ErrorEnum.NoError) ? record.BizObject : null),
                Code = record.Code,
                Message = record.Message,
                RowsAffected = record.RowsAffected
            };
        }
        public ReturnInfo GetUserByUserName(SmartDB dbInstance, string UserName)
        {
            IInfo record = _dal.GetRecordsByUserName(dbInstance, UserName);
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
            IInfo records = _dal.GetRecords(dbInstance);
            return new ReturnInfo
            {
                Code = records.Code,
                Message = records.Message,
                BizObject = ((records.Code == ErrorEnum.NoError) ? records.BizObject : new List<Model.City>())
            };
        }
        public static bool CheckPassword(string Username, string Password)
        {
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());
            var user = userManager.FindByName(Username);
            var checkPassword = userManager.CheckPassword(user, Password);
            return checkPassword;
        }
    }
}
