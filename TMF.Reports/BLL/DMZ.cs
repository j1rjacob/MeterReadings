﻿using System.Collections.Generic;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.BLL
{
    public class DMZ : BusinessBase
    {
        private static readonly DAL.DMZ _dal = new DAL.DMZ();
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
        public ReturnInfo IsValid(Model.DMZ info)
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
        public ReturnInfo Create(SmartDB dbInstance, ref Model.DMZ info)
        {
            IInfo info2 = _dal.Insert(dbInstance, info);
            info.IsNew = false;
            info.IsDirty = true;
            return new ReturnInfo(info2.Code, info2.Message);
        }
        public ReturnInfo Update(SmartDB dbInstance, Model.DMZ info)
        {
            IInfo info2 = _dal.GetRecord(dbInstance, info.Id);
            bool flag = info2.Code == ErrorEnum.NoError;
            ReturnInfo result;
            if (flag)
            {
                bool flag2 = (info2.BizObject as Model.DMZ).LockCount == info.LockCount;
                if (!flag2)
                {
                    result = new ReturnInfo(ErrorEnum.ColumnReference, "Record has been changed.");
                    return result;
                }
                info.LockCount++;
                info2 = _dal.Update(dbInstance, info);
            }
            result = new ReturnInfo(info2.Code, info2.Message, info2.RowsAffected);
            return result;
        }
        public ReturnInfo Delete(SmartDB dbInstance, int Id)
        {
            bool flag = Id == 0;
            ReturnInfo result;
            if (flag)
            {
                result = new ReturnInfo(ErrorEnum.InvalidInput, "Invalid input. ID not found.");
            }
            else
            {
                IInfo info = _dal.Delete(dbInstance, Id);
                result = new ReturnInfo(info.Code, info.Message, info.RowsAffected);
            }
            return result;
        }
        public ReturnInfo GetDMZById(SmartDB dbInstance, int Id)
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
        public ReturnInfo GetDMZByDescription(SmartDB dbInstance, string Description)
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
        public ReturnInfo GetTopDMZ(SmartDB dbInstance)
        {
            IInfo record = _dal.GetRecordTop(dbInstance);
            return new ReturnInfo
            {
                BizObject = ((record.Code == ErrorEnum.NoError) ? record.BizObject : null),
                Code = record.Code,
                Message = record.Message,
                RowsAffected = record.RowsAffected
            };
        }
        public ReturnInfo GetDMZList(SmartDB dbInstance)
        {
            IInfo records = _dal.GetRecords(dbInstance);
            return new ReturnInfo
            {
                Code = records.Code,
                Message = records.Message,
                BizObject = ((records.Code == ErrorEnum.NoError) ? records.BizObject : new List<Model.DMZ>())
            };
        }
    }
}
