using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TMF.Core.Model;

namespace TMF.Core.DAL
{
    public class UserInfoDAL
    {
        private const string SQL_INSERT = "USER_INS";

        private const string SQL_UPDATE = "USER_UPD";

        private const string SQL_UPDATE_LOGIN = "USER_ISLOGIN_UPD";

        private const string SQL_DELETE = "USER_DEL";

        private const string SQL_REMOVE = "USER_DID";

        private const string SQL_GET_COMPANY = "USER_GET_COMPANY";

        private const string SQL_GET_ROLE = "USER_GET_ROLE";

        private const string SQL_GET_USER_ID = "USER_GET_USER_ID";

        private const string SQL_GET_ID = "USER_GID";

        private const string SQL_GET_LIST = "USER_LST";

        private const string PARM_ID = "@ID";

        private const string PARM_USER_ID = "@USER_ID";

        private const string PARM_PASSWORD = "@PASSWORD";

        private const string PARM_NAME = "@NAME";

        private const string PARM_ROLE_ID = "@ROLE_ID";

        private const string PARM_EMAIL = "@EMAIL";

        private const string PARM_COMPANY = "@COMPANY";

        private const string PARM_LANGUAGE_ID = "@LANGUAGE_ID";

        private const string PARM_IS_DELETE = "@IS_DELETE";

        private const string PARM_IS_LOCK = "@IS_LOCK";

        private const string PARM_CREATED_BY = "@CREATED_BY";

        private const string PARM_DATE_CREATED = "@DATE_CREATED";

        private const string PARM_MODIFIED_BY = "@MODIFIED_BY";

        private const string PARM_DATE_MODIFIED = "@DATE_MODIFIED";

        private const string PARM_REMARK = "@REMARK";

        private const string PARM_LOCK_COUNT = "@LOCK_COUNT";

        private const string PARM_IS_LOGIN = "@IS_LOGIN";

        private SqlParameter[] GetInsertParameters(string connectionString)
        {
            SqlParameter[] array = SqlHelper.GetCachedParameters("USER_INS");
            bool flag = array == null;
            if (flag)
            {
                array = SqlHelper.GetParameters(connectionString, "USER_INS");
            }
            return array;
        }

        private SqlParameter[] GetUpdateParameters(string connectionString)
        {
            SqlParameter[] array = SqlHelper.GetCachedParameters("USER_UPD");
            bool flag = array == null;
            if (flag)
            {
                array = SqlHelper.GetParameters(connectionString, "USER_UPD");
            }
            return array;
        }

        protected void SetInfo(out UserInfo info, SqlDataReader rdr)
        {
            try
            {
                info = new UserInfo();
                info.Created_By = CastDBNull.To<string>(rdr["Created_By"], "");
                info.Date_Created = CastDBNull.To<DateTime>(rdr["Date_Created"], DateTime.Today);
                info.Date_Modified = CastDBNull.To<DateTime>(rdr["Date_Modified"], DateTime.Today);
                info.Id = CastDBNull.To<long>(rdr["Id"], 0L);
                info.Is_Delete = CastDBNull.To<bool>(rdr["Is_Delete"], false);
                info.Is_Lock = CastDBNull.To<bool>(rdr["Is_Lock"], false);
                info.Language_Id = CastDBNull.To<int?>(rdr["Language_Id"], null);
                info.Lock_Count = CastDBNull.To<int>(rdr["Lock_Count"], 1);
                info.Modified_By = CastDBNull.To<string>(rdr["Modified_By"], "admin");
                info.Remark = CastDBNull.To<string>(rdr["Remark"], "");
                info.User_Id = CastDBNull.To<string>(rdr["User_Id"], "");
                info.Password = CastDBNull.To<string>(rdr["Password"], "");
                info.Name = CastDBNull.To<string>(rdr["Name"], "");
                info.Role_Id = CastDBNull.To<int>(rdr["Role_Id"], 1);
                info.Email = CastDBNull.To<string>(rdr["Email"], "");
                info.Company = CastDBNull.To<string>(rdr["Company"], "");
                info.Is_Login = CastDBNull.To<bool>(rdr["Is_Login"], false);
                info.Is_Active = CastDBNull.To<bool>(rdr["Is_Active"], false);
                info.Title = CastDBNull.To<string>(rdr["Title"], "");
                info.Office = CastDBNull.To<string>(rdr["Office"], "Kota Kemuning, HQ");
                info.Manager = CastDBNull.To<string>(rdr["Manager"], "");
                info.Manager_Id = CastDBNull.To<long?>(rdr["Manager_Id"], null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IInfo Insert(SmartDB dbInstance, ref UserInfo info)
        {
            SqlParameter[] insertParameters = this.GetInsertParameters(dbInstance.Connection.ConnectionString);
            string cmdText = "USER_INS";
            insertParameters[0].Value = info.User_Id;
            insertParameters[1].Value = info.Password;
            insertParameters[2].Value = info.Name;
            insertParameters[3].Value = info.Role_Id;
            insertParameters[4].Value = info.Email;
            insertParameters[5].Value = info.Company;
            bool flag = !info.Language_Id.HasValue;
            if (flag)
            {
                insertParameters[6].Value = DBNull.Value;
            }
            else
            {
                insertParameters[6].Value = info.Language_Id;
            }
            insertParameters[7].Value = info.Is_Delete;
            insertParameters[8].Value = info.Is_Lock;
            insertParameters[9].Value = info.Created_By;
            insertParameters[10].Value = info.Date_Created;
            insertParameters[11].Value = info.Modified_By;
            insertParameters[12].Value = info.Date_Modified;
            insertParameters[13].Value = info.Lock_Count;
            insertParameters[14].Value = info.Remark;
            insertParameters[15].Value = info.Is_Login;
            insertParameters[16].Value = info.Is_Active;
            insertParameters[17].Value = info.Title;
            insertParameters[18].Value = info.Office;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, insertParameters);
                    bool hasRows = sqlDataReader.HasRows;
                    if (!hasRows)
                    {
                        result = new ReturnInfo(ErrorEnum.TransactionError, "Insert User failed");
                        return result;
                    }
                    sqlDataReader.Read();
                    long id = Convert.ToInt64(sqlDataReader[0]);
                    info.Id = id;
                    sqlDataReader.Close();
                }
                else
                {
                    SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, insertParameters);
                    bool hasRows2 = sqlDataReader.HasRows;
                    if (!hasRows2)
                    {
                        result = new ReturnInfo(ErrorEnum.TransactionError, "Insert User failed");
                        return result;
                    }
                    sqlDataReader.Read();
                    long id = Convert.ToInt64(sqlDataReader[0]);
                    info.Id = id;
                    sqlDataReader.Close();
                }
            }
            catch (Exception ex)
            {
                bool flag2 = ex.Message.Contains("unique constraint");
                if (flag2)
                {
                    result = new ReturnInfo(ErrorEnum.UniqueConstraint, string.Format("User {0} already exist in the system", info.Name));
                    return result;
                }
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
                return result;
            }
            result = new ReturnInfo(ErrorEnum.NoError, "", 1);
            return result;
        }

        public IInfo Update(SmartDB dbInstance, UserInfo info)
        {
            int rowsAffected = 0;
            SqlParameter[] updateParameters = this.GetUpdateParameters(dbInstance.Connection.ConnectionString);
            string cmdText = "USER_UPD";
            updateParameters[0].Value = info.Id;
            updateParameters[1].Value = info.User_Id;
            updateParameters[2].Value = info.Password;
            updateParameters[3].Value = info.Name;
            updateParameters[4].Value = info.Role_Id;
            updateParameters[5].Value = info.Email;
            updateParameters[6].Value = info.Company;
            bool flag = !info.Language_Id.HasValue;
            if (flag)
            {
                updateParameters[7].Value = DBNull.Value;
            }
            else
            {
                updateParameters[7].Value = info.Language_Id;
            }
            updateParameters[8].Value = info.Is_Delete;
            updateParameters[9].Value = info.Is_Lock;
            updateParameters[10].Value = info.Created_By;
            updateParameters[11].Value = info.Date_Created;
            updateParameters[12].Value = info.Modified_By;
            updateParameters[13].Value = info.Date_Modified;
            updateParameters[14].Value = info.Lock_Count;
            updateParameters[15].Value = info.Remark;
            updateParameters[16].Value = info.Is_Login;
            updateParameters[17].Value = info.Is_Active;
            updateParameters[18].Value = info.Title;
            updateParameters[19].Value = info.Office;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, updateParameters);
                }
                else
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, updateParameters);
                }
            }
            catch (Exception ex)
            {
                bool flag2 = ex.Message.Contains("unique constraint");
                if (flag2)
                {
                    result = new ReturnInfo(ErrorEnum.UniqueConstraint, string.Format("User {0} already exist in the system", info.Name));
                    return result;
                }
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
                return result;
            }
            result = new ReturnInfo(ErrorEnum.NoError, "", rowsAffected);
            return result;
        }

        public IInfo UpdateLoginStatus(SmartDB dbInstance, string userId, bool isLogin)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = SqlHelper.GetParameters(dbInstance.Connection.ConnectionString, "USER_ISLOGIN_UPD");
            string cmdText = "USER_ISLOGIN_UPD";
            parameters[0].Value = isLogin;
            parameters[1].Value = userId;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, parameters);
                }
                else
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, parameters);
                }
            }
            catch (Exception ex)
            {
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
                return result;
            }
            result = new ReturnInfo(ErrorEnum.NoError, "", rowsAffected);
            return result;
        }

        public IInfo Delete(SmartDB dbInstance, long Id)
        {
            int rowsAffected = 0;
            string cmdText = "USER_DEL";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@ID", SqlDbType.BigInt)
            };
            array[0].Value = Id;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, array);
                }
                else
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, array);
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

        public IInfo Remove(SmartDB dbInstance, long Id)
        {
            int rowsAffected = 0;
            string cmdText = "USER_DID";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@ID", SqlDbType.BigInt)
            };
            array[0].Value = Id;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, array);
                }
                else
                {
                    rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, array);
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

        public IInfo GetRecord(SmartDB dbInstance, string userId, out UserInfo info)
        {
            info = null;
            string cmdText = "USER_GET_USER_ID";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@USER_ID", SqlDbType.NVarChar)
            };
            array[0].Value = userId;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    using (SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, array))
                    {
                        bool hasRows = sqlDataReader.HasRows;
                        if (!hasRows)
                        {
                            result = new ReturnInfo(ErrorEnum.NoRecord, string.Format("No record found for ID: {0}", userId));
                            return result;
                        }
                        sqlDataReader.Read();
                        this.SetInfo(out info, sqlDataReader);
                    }
                }
                else
                {
                    using (SqlDataReader sqlDataReader2 = SqlHelper.ExecuteReader(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, array))
                    {
                        bool hasRows2 = sqlDataReader2.HasRows;
                        if (!hasRows2)
                        {
                            result = new ReturnInfo(ErrorEnum.NoRecord, string.Format("No record found for ID: {0}", userId));
                            return result;
                        }
                        sqlDataReader2.Read();
                        this.SetInfo(out info, sqlDataReader2);
                    }
                }
            }
            catch (Exception ex)
            {
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
                return result;
            }
            result = new ReturnInfo();
            return result;
        }

        public IInfo GetRecord(SmartDB dbInstance, long Id, out UserInfo info)
        {
            info = null;
            string cmdText = "USER_GID";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@ID", SqlDbType.BigInt)
            };
            array[0].Value = Id;
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    using (SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, array))
                    {
                        bool hasRows = sqlDataReader.HasRows;
                        if (!hasRows)
                        {
                            result = new ReturnInfo(ErrorEnum.NoRecord, string.Format("No record found for ID: {0}", Id));
                            return result;
                        }
                        sqlDataReader.Read();
                        this.SetInfo(out info, sqlDataReader);
                    }
                }
                else
                {
                    using (SqlDataReader sqlDataReader2 = SqlHelper.ExecuteReader(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, array))
                    {
                        bool hasRows2 = sqlDataReader2.HasRows;
                        if (!hasRows2)
                        {
                            result = new ReturnInfo(ErrorEnum.NoRecord, string.Format("No record found for ID: {0}", Id));
                            return result;
                        }
                        sqlDataReader2.Read();
                        this.SetInfo(out info, sqlDataReader2);
                    }
                }
            }
            catch (Exception ex)
            {
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
                return result;
            }
            result = new ReturnInfo();
            return result;
        }

        public IInfo GetRecords(SmartDB dbInstance, out List<UserInfo> list)
        {
            list = new List<UserInfo>();
            IInfo result;
            try
            {
                bool transactionControl = dbInstance.TransactionControl;
                if (transactionControl)
                {
                    using (SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, "USER_LST", new SqlParameter[0]))
                    {
                        while (sqlDataReader.Read())
                        {
                            UserInfo item;
                            this.SetInfo(out item, sqlDataReader);
                            list.Add(item);
                        }
                    }
                }
                else
                {
                    using (SqlDataReader sqlDataReader2 = SqlHelper.ExecuteReader(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, "USER_LST", new SqlParameter[0]))
                    {
                        while (sqlDataReader2.Read())
                        {
                            UserInfo item2;
                            this.SetInfo(out item2, sqlDataReader2);
                            list.Add(item2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
                return result;
            }
            result = new ReturnInfo();
            return result;
        }
    }
}
