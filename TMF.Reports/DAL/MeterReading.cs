using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.DAL
{
    public class MeterReading : BaseDAL
    {
        public MeterReading()
        {
            SQL_DELETE = "[REPORT METERREADING_DEL]";
            SQL_GET = "[REPORT METERREADING_GET]";
            SQL_GET_LIST = "[REPORT METERREADING_LST]";
            SQL_INSERT = "[REPORT METERREADING_INS]";
            SQL_UPDATE = "[REPORT METERREADING_UPD]";
            PARM_ID = "@Id";
        }
        protected void SetInfo(out Model.MeterReading info, SqlDataReader reader)
        {
            try
            {
                info = new Model.MeterReading();
                info.Id = CastDBNull.To<string>(reader["Id"], "");
                info.SerialNumber = CastDBNull.To<string>(reader["SerialNumber"], "");
                info.ReadingDate = CastDBNull.To<DateTime>(reader["ReadingDate"], DateTime.Now);
                info.CSVType = CastDBNull.To<string>(reader["CSVType"], "");
                info.ReadingValue = CastDBNull.To<string>(reader["ReadingValue"], "");
                info.LowBatteryAlr = CastDBNull.To<int>(reader["LowBatteryAlr"], 0);
                info.LeakAlr = CastDBNull.To<int>(reader["LeakAlr"], 0);
                info.MagneticTamperAlr = CastDBNull.To<int>(reader["MagneticTamperAlr"], 0);
                info.MeterErrorAlr = CastDBNull.To<int>(reader["MeterErrorAlr"], 0);
                info.BackFlowAlr = CastDBNull.To<int>(reader["BackFlowAlr"], 0);
                info.BrokenPipeAlr = CastDBNull.To<int>(reader["BrokenPipeAlr"], 0);
                info.EmptyPipeAlr = CastDBNull.To<int>(reader["EmptyPipeAlr"], 0);
                info.SpecificErr = CastDBNull.To<int>(reader["SpecificErr"], 0);
                info.FlowRateValue = CastDBNull.To<int>(reader["FlowRateValue"], 0);
                info.AppBusyAlr = CastDBNull.To<int>(reader["AppBusyAlr"], 0);
                info.AnyAppErrorAlr = CastDBNull.To<int>(reader["AnyAppErrorAlr"], 0);
                info.AbnormalConditionAlr = CastDBNull.To<int>(reader["AbnormalConditionAlr"], 0);
                info.PermanentErrorAlr = CastDBNull.To<int>(reader["PermanentErrorAlr"], 0);
                info.TemporaryErrorAlr = CastDBNull.To<int>(reader["TemporaryErrorAlr"], 0);
                info.SpecificError1Alr = CastDBNull.To<int>(reader["SpecificError1Alr"], 0);
                info.SpecificError2Alr = CastDBNull.To<int>(reader["SpecificError2Alr"], 0);
                info.SpecificError3Alr = CastDBNull.To<int>(reader["SpecificError3Alr"], 0);
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
            Model.MeterReading bizObject = null;
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
            var list = new List<Model.MeterReading>();
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
                        Model.MeterReading item;
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
            string cmdText = "[REPORT METERREADING_LST_BYDESCRIPTION]";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@Description", SqlDbType.NVarChar)
            };
            array[0].Value = description;
            return this.GetRecords(dbInstance, cmdText, array);
        }
    }
}
