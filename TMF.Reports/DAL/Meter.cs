using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.DAL
{
    public class Meter : BaseDAL
    {
        public Meter()
        {
            SQL_DELETE = "[REPORT METER_DEL]";
            SQL_GET = "[REPORT METER_GET]";
            SQL_GET_LIST = "[REPORT METER_LST]";
            SQL_INSERT = "[REPORT METER_INS]";
            SQL_UPDATE = "[REPORT METER_UPD]";
            PARM_ID = "@Id";
        }
        protected void SetInfo(out Model.Meter info, SqlDataReader reader)
        {
            try
            {
                info = new Model.Meter();
                info.Id = CastDBNull.To<string>(reader["Id"], "");
                info.SerialNumber = CastDBNull.To<string>(reader["SerialNumber"], "");
                info.X = CastDBNull.To<decimal>(reader["X"], 0.0m);
                info.Y = CastDBNull.To<decimal>(reader["Y"], 0.0m);
                info.Status = CastDBNull.To<string>(reader["Status"], "");
                info.HCN = CastDBNull.To<string>(reader["HCN"], "");
                info.InstallationDate = CastDBNull.To<DateTime>(reader["InstallationDate"], DateTime.Now);
                info.MaintenanceDate = CastDBNull.To<DateTime>(reader["MaintenanceDate"], DateTime.Now);
                info.MeterTypeId = CastDBNull.To<string>(reader["MeterTypeId"], "");
                info.MeterSizeId = CastDBNull.To<string>(reader["MeterSizeId"], "");
                info.MeterProtocolId = CastDBNull.To<string>(reader["MeterProtocolId"], "");
                info.DMZId = CastDBNull.To<string>(reader["DMZId"], "");
                info.CityId = CastDBNull.To<string>(reader["CityId"], "");
                info.CreatedBy = CastDBNull.To<string>(reader["Createdby"], "");
                info.EditedBy = CastDBNull.To<string>(reader["Editedby"], "");
                info.DocDate = CastDBNull.To<DateTime>(reader["DocDate"], DateTime.Now);
                info.Show = CastDBNull.To<int>(reader["Show"], 1);
                info.LockCount = CastDBNull.To<int>(reader["LockCount"], 1);
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
            Model.Meter bizObject = null;
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
            var list = new List<Model.Meter>();
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
                        Model.Meter item;
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
            string cmdText = "[REPORT METER_LST_BYDESCRIPTION]";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@Description", SqlDbType.NVarChar)
            };
            array[0].Value = description;
            return this.GetRecords(dbInstance, cmdText, array);
        }
    }
}
