﻿using System.Collections.Generic;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.BLL
{
    public class Roles : BusinessBase
    {
        private static readonly DAL.Roles _dal = new DAL.Roles();

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
        public ReturnInfo IsValid(Model.Roles info)
        {
            bool flag = string.IsNullOrEmpty(info.Id);
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
        //public ReturnInfo Create(SmartDB dbInstance, ref Model.Roles info)
        //{
        //    IInfo info2 = _dal.Insert(dbInstance, info);
        //    info.IsNew = false;
        //    info.IsDirty = true;
        //    return new ReturnInfo(info2.Code, info2.Message);
        //}
        //public ReturnInfo Update(SmartDB dbInstance, Model.Roles info)
        //{
        //    IInfo info2 = _dal.GetRecord(dbInstance, info.Id);
        //    bool flag = info2.Code == ErrorEnum.NoError;
        //    ReturnInfo result;
        //    if (flag)
        //    {
        //        bool flag2 = (info2.BizObject as Model.City).LockCount == info.LockCount;
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
        public ReturnInfo GetRolesById(SmartDB dbInstance, string Id)
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
        public ReturnInfo GetRolesByDescription(SmartDB dbInstance, string Description)
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
        public ReturnInfo GetRolesList(SmartDB dbInstance)
        {
            IInfo records = _dal.GetRecords(dbInstance);
            return new ReturnInfo
            {
                Code = records.Code,
                Message = records.Message,
                BizObject = ((records.Code == ErrorEnum.NoError) ? records.BizObject : new List<Model.Roles>())
            };
        }
    }
}
