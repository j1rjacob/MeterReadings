﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.DAL
{
    public class User : BaseDAL
    {
        public User()
        {
            SQL_DELETE = "[REPORT USER_DEL]";
            SQL_GET = "[REPORT USER_GET]";
            SQL_GET_LIST = "[REPORT USER_LST_BYUSERNAME]";
            SQL_INSERT = "[REPORT USER_INS]";
            SQL_UPDATE = "[REPORT USER_UPD]";
            PARM_ID = "@Id";
        }
        protected void SetInfo(out Model.User info, SqlDataReader reader)
        {
            try
            {
                info = new Model.User();
                info.Id = CastDBNull.To<string>(reader["Id"], "");
                info.Email = CastDBNull.To<string>(reader["Email"], "");
                info.EmailConfirmed = CastDBNull.To<bool>(reader["EmailConfirmed"], true);
                info.PasswordHash = CastDBNull.To<string>(reader["PasswordHash"], "");
                info.SecurityStamp = CastDBNull.To<string>(reader["SecurityStamp"], "");
                info.PhoneNumber = CastDBNull.To<string>(reader["PhoneNumber"], "");
                info.TwoFactorEnabled = CastDBNull.To<bool>(reader["TwoFactorEnabled"], false);
                info.LockoutEndDateUtc = CastDBNull.To<DateTime>(reader["LockoutEndDateUtc"], DateTime.Now);
                info.LockoutEnabled = CastDBNull.To<bool>(reader["LockoutEnabled"], false);
                info.AccessFailedCount = CastDBNull.To<int>(reader["AccessFailedCount"], 0);
                info.UserName = CastDBNull.To<string>(reader["UserName"], "");
                info.RoleName = CastDBNull.To<string>(reader["RoleName"], "");
                info.IsNew = false;
                info.IsDirty = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override IInfo GetRecord(SmartDB dbInstance, object Id)
        {
            string sQL_GET = this.SQL_GET;
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter(this.PARM_ID, SqlDbType.NVarChar)
            };
            array[0].Value = Id;
            Model.User bizObject = null;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                SqlDataReader sqlDataReader;
                if (transactionControl)
                {
                    sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, sQL_GET, array);
                }
                else
                {
                    sqlDataReader = SqlHelper.ExecuteReader(SqlHelper.MyConnectionString, CommandType.StoredProcedure, sQL_GET, array);
                }
                bool hasRows = sqlDataReader.HasRows;
                if (hasRows)
                {
                    sqlDataReader.Read();
                    this.SetInfo(out bizObject, sqlDataReader);
                    result = new ReturnInfo
                    {
                        BizObject = bizObject,
                        Code = ErrorEnum.NoError
                    };
                }
                else
                {
                    result = new ReturnInfo(ErrorEnum.NoRecord, string.Format("No record found for ID: {0}", Id));
                }
            }
            catch (Exception ex)
            {
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
            }
            return result;
        }
        protected IInfo GetRecords(SmartDB dbInstance, string cmdText, SqlParameter[] parms)
        {
            var list = new List<Model.User>();
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                SqlDataReader sqlDataReader;
                if (transactionControl)
                {
                    bool flag = parms == null;
                    if (flag)
                    {
                        sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, Array.Empty<SqlParameter>());
                    }
                    else
                    {
                        sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, parms);
                    }
                }
                else
                {
                    bool flag2 = parms == null;
                    if (flag2)
                    {
                        sqlDataReader = SqlHelper.ExecuteReader(SqlHelper.MyConnectionString, CommandType.StoredProcedure, cmdText, Array.Empty<SqlParameter>());
                    }
                    else
                    {
                        sqlDataReader = SqlHelper.ExecuteReader(SqlHelper.MyConnectionString, CommandType.StoredProcedure, cmdText, parms);
                    }
                }
                bool hasRows = sqlDataReader.HasRows;
                if (hasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        Model.User item;
                        this.SetInfo(out item, sqlDataReader);
                        list.Add(item);
                    }
                    result = new ReturnInfo
                    {
                        BizObject = list,
                        Code = ErrorEnum.NoError
                    };
                }
                else
                {
                    result = new ReturnInfo
                    {
                        Message = "No records found",
                        Code = ErrorEnum.NoRecord
                    };
                }
            }
            catch (Exception ex)
            {
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
            }
            return result;
        }
        public override IInfo GetRecords(SmartDB dbInstance)
        {
            string sQL_GET_LIST = this.SQL_GET_LIST;
            return this.GetRecords(dbInstance, sQL_GET_LIST, null);
        }
        public IInfo GetRecordsByDescription(SmartDB dbInstance, string description)
        {
            string cmdText = "[REPORT USER_LST_BYDESCRIPTION]";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@Description", SqlDbType.NVarChar)
            };
            array[0].Value = description;
            return this.GetRecords(dbInstance, cmdText, array);
        }
        public IInfo GetRecordsByUserName(SmartDB dbInstance, string username)
        {
            string cmdText = "[REPORT USER_LST_BYUSERNAME]";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@UserName", SqlDbType.NVarChar)
            };
            array[0].Value = username;
            return this.GetRecords(dbInstance, cmdText, array);
        }
    }
}
