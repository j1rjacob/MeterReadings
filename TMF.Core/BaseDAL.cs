using System;
using System.Data;
using System.Data.SqlClient;
using TMF.Core.Model;

namespace TMF.Core
{
    public class BaseDAL
    {
        protected string SQL_INSERT = "";

        protected string SQL_UPDATE = "";

        protected string SQL_DELETE = "";

        protected string SQL_GET = "";

        protected string SQL_GET_LIST = "";

        protected string PARM_ID = "";

        protected virtual SqlParameter[] GetInsertParameters(SmartDB dbInstance)
        {
            return SqlHelper.GetParameters(new SmartDB(), this.SQL_INSERT);
        }

        protected virtual SqlParameter[] GetUpdateParameters(SmartDB dbInstance)
        {
            return SqlHelper.GetParameters(new SmartDB(), this.SQL_UPDATE);
        }

        protected virtual SqlParameter[] GetParameters(string storedProc)
        {
            return SqlHelper.GetParameters(storedProc);
        }

        public virtual IInfo Insert(SmartDB dbInstance, ModelInfo info)
        {
            SqlParameter[] insertParameters = this.GetInsertParameters(dbInstance);
            string sQL_INSERT = this.SQL_INSERT;
            IInfo result;
            try
            {
                for (int i = 0; i < insertParameters.Length; i++)
                {
                    string fieldname = insertParameters[i].ParameterName.Remove(0, 1);
                    bool flag = info[fieldname] == null;
                    if (flag)
                    {
                        insertParameters[i].Value = DBNull.Value;
                    }
                    else
                    {
                        bool flag2 = insertParameters[i].DbType == DbType.DateTime || insertParameters[i].DbType == DbType.Date || insertParameters[i].DbType == DbType.DateTime2;
                        if (flag2)
                        {
                            insertParameters[i].Value = Convert.ToDateTime(info[fieldname]).ToString("dd-MMM-yyyy hh:mm:ss tt");
                        }
                        else
                        {
                            insertParameters[i].Value = info[fieldname];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                bool flag3 = ex.Message.Contains("null reference");
                if (flag3)
                {
                    result = new ReturnInfo(ErrorEnum.NullReference, ex.Message);
                    return result;
                }
                result = new ReturnInfo(ErrorEnum.Exception, ex.Message);
                return result;
            }
            SqlDataReader sqlDataReader = null;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, sQL_INSERT, insertParameters);
                }
                else
                {
                    sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, sQL_INSERT, insertParameters);
                }
                bool flag4 = !sqlDataReader.Read();
                if (flag4)
                {
                    sqlDataReader.Dispose();
                    result = new ReturnInfo(ErrorEnum.TransactionError, "Insert record failed");
                    return result;
                }
                bool flag5 = sqlDataReader.GetDecimal(0) == -99m;
                if (flag5)
                {
                    sqlDataReader.Dispose();
                    result = new ReturnInfo(ErrorEnum.DuplicateRecord, "Record already exists");
                    return result;
                }
                bool flag6 = sqlDataReader.GetDecimal(0) == decimal.MinusOne;
                if (flag6)
                {
                    sqlDataReader.Dispose();
                    result = new ReturnInfo(ErrorEnum.TransactionError, "Insert record failed");
                    return result;
                }
                string fieldname2 = this.PARM_ID.Remove(0, 1);
                info[fieldname2] = Convert.ToInt32(sqlDataReader.GetDecimal(0));
            }
            catch (Exception ex2)
            {
                bool flag7 = ex2.Message.Contains("unique constraint");
                if (flag7)
                {
                    result = new ReturnInfo(ErrorEnum.UniqueConstraint, "Record already exist in the system");
                    return result;
                }
                result = new ReturnInfo(ErrorEnum.DataException, ex2.Message);
                return result;
            }
            finally
            {
                bool flag8 = sqlDataReader != null;
                if (flag8)
                {
                    sqlDataReader.Dispose();
                }
            }
            result = new ReturnInfo
            {
                Code = ErrorEnum.NoError,
                Message = "",
                BizObject = info,
                RowsAffected = 1
            };
            return result;
        }

        public virtual IInfo Update(SmartDB dbInstance, ModelInfo info)
        {
            int rowsAffected = 0;
            SqlParameter[] updateParameters = this.GetUpdateParameters(dbInstance);
            string sQL_UPDATE = this.SQL_UPDATE;
            IInfo result;
            try
            {
                for (int i = 0; i < updateParameters.Length; i++)
                {
                    string fieldname = updateParameters[i].ParameterName.Remove(0, 1);
                    bool flag = info[fieldname] == null;
                    if (flag)
                    {
                        updateParameters[i].Value = DBNull.Value;
                    }
                    else
                    {
                        bool flag2 = updateParameters[i].DbType == DbType.DateTime || updateParameters[i].DbType == DbType.Date || updateParameters[i].DbType == DbType.DateTime2;
                        if (flag2)
                        {
                            updateParameters[i].Value = Convert.ToDateTime(info[fieldname]).ToString("dd-MMM-yyyy");
                        }
                        else
                        {
                            updateParameters[i].Value = info[fieldname];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                bool flag3 = ex.Message.Contains("null reference");
                if (flag3)
                {
                    result = new ReturnInfo(ErrorEnum.NullReference, ex.Message);
                    return result;
                }
                result = new ReturnInfo(ErrorEnum.Exception, ex.Message);
                return result;
            }
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Transaction, CommandType.StoredProcedure, sQL_UPDATE, updateParameters);
                }
                else
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, sQL_UPDATE, updateParameters);
                }
            }
            catch (Exception ex2)
            {
                bool flag4 = ex2.Message.Contains("unique constraint");
                if (flag4)
                {
                    result = new ReturnInfo(ErrorEnum.UniqueConstraint, string.Format("Record: {0} already exist in the system", info["ID"]));
                    return result;
                }
                result = new ReturnInfo(ErrorEnum.DataException, ex2.Message);
                return result;
            }
            result = new ReturnInfo(ErrorEnum.NoError, "", rowsAffected);
            return result;
        }

        public virtual IInfo Delete(SmartDB dbInstance, object Id)
        {
            int rowsAffected = 0;
            string sQL_DELETE = this.SQL_DELETE;
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter(this.PARM_ID, SqlDbType.Int)
            };
            array[0].Value = Id;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Transaction, CommandType.StoredProcedure, sQL_DELETE, array);
                }
                else
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, sQL_DELETE, array);
                }
            }
            catch (Exception ex)
            {
                bool flag = ex.Message.Contains("COLUMN REFERENCE");
                if (flag)
                {
                    result = new ReturnInfo(ErrorEnum.ColumnReference, "Record is still in use or being referenced by other object");
                    return result;
                }
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
                return result;
            }
            result = new ReturnInfo(ErrorEnum.NoError, "", rowsAffected);
            return result;
        }

        public virtual IInfo GetRecord(SmartDB dbInstance, object Id)
        {
            return null;
        }

        public virtual IInfo GetRecords(SmartDB dbInstance)
        {
            return null;
        }
    }
}
