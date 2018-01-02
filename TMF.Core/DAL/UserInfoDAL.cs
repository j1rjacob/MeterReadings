using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TMF.Core.Model;

namespace TMF.Core.DAL
{
    public class UserInfoDAL
    {
        private const string SQL_INSERT = "REPORT USERINFO_INS";

        private const string SQL_UPDATE = "REPORT USERINFO_UPD";

        private const string SQL_UPDATE_LOGIN = "REPORT USERINFO_ISLOGIN_UPD";

        private const string SQL_DELETE = "REPORT USERINFO_DEL";

        private const string SQL_REMOVE = "REPORT USERINFO_DID";

        private const string SQL_GET_ROLE = "REPORT USERINFO_GET_ROLE";

        private const string SQL_GET_USER_ID = "REPORT USERINFO_GET_USER_ID";

        private const string SQL_GET_ID = "REPORT USERINFO_GID";

        private const string SQL_GET_LIST = "REPORT USERINFO_LST";

        private const string PARM_ID = "@ID";

        private const string PARM_USERID = "@USERID";

        private const string PARM_PASSWORD = "@PASSWORD";

        private const string PARM_NAME = "@NAME";

        private const string PARM_ROLEID = "@ROLEID";

        private const string PARM_EMAIL = "@EMAIL";

        private const string PARM_ISDELETE = "@ISDELETE";

        private const string PARM_ISLOCK = "@ISLOCK";

        private const string PARM_CREATEDBY = "@CREATEDBY";

        private const string PARM_DATECREATED = "@DATECREATED";

        private const string PARM_EDITEDBY = "@EDITEDBY";

        private const string PARM_DATEEDITED = "@DATEEDITED";

        private const string PARM_REMARK = "@REMARK";

        private const string PARM_LOCKCOUNT = "@LOCKCOUNT";

        private const string PARM_ISLOGIN = "@ISLOGIN";

        private SqlParameter[] GetInsertParameters(string connectionString)
        {
            SqlParameter[] array = SqlHelper.GetCachedParameters("REPORT USERINFO_INS");
            bool flag = array == null;
            if (flag)
            {
                array = SqlHelper.GetParameters(connectionString, "REPORT USERINFO_INS");
            }
            return array;
        }

        private SqlParameter[] GetUpdateParameters(string connectionString)
        {
            SqlParameter[] array = SqlHelper.GetCachedParameters("REPORT USERINFO_UPD");
            bool flag = array == null;
            if (flag)
            {
                array = SqlHelper.GetParameters(connectionString, "REPORT USERINFO_UPD");
            }
            return array;
        }

        protected void SetInfo(out UserInfo info, SqlDataReader rdr)
        {
            try
            {
                info = new UserInfo();
                info.Id = CastDBNull.To<string>(rdr["Id"], "");
                info.Username = CastDBNull.To<string>(rdr["Username"], "");
                info.Password = CastDBNull.To<string>(rdr["Password"], "");
                info.Name = CastDBNull.To<string>(rdr["Name"], "");
                info.Role = CastDBNull.To<int>(rdr["Role"], 2);
                info.IsActive = CastDBNull.To<bool>(rdr["IsActive"], false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IInfo Insert(SmartDB dbInstance, ref UserInfo info)
        {
            SqlParameter[] insertParameters = this.GetInsertParameters(dbInstance.Connection.ConnectionString);
            string cmdText = "REPORT USERINFO_INS";
            insertParameters[0].Value = info.Id;
            insertParameters[1].Value = info.Username;
            insertParameters[2].Value = info.Password;
            insertParameters[3].Value = info.Name;
            insertParameters[4].Value = info.Role;
            insertParameters[5].Value = info.IsActive;
            IInfo result;
            //try
            //{
            //    bool transactionControl = dbInstance.TransactionControl;
            //    if (transactionControl)
            //    {
            //        SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, insertParameters);
            //        bool hasRows = sqlDataReader.HasRows;
            //        if (!hasRows)
            //        {
            //            result = new ReturnInfo(ErrorEnum.TransactionError, "Insert User failed");
            //            return result;
            //        }
            //        sqlDataReader.Read();
            //        string id = Convert.ToString(sqlDataReader[0]);
            //        info.Id = id;
            //        sqlDataReader.Close();
            //    }
            //    else
            //    {
                    SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, insertParameters);
                    bool hasRows2 = sqlDataReader.HasRows;
                    if (hasRows2)
                    {
                        result = new ReturnInfo(ErrorEnum.TransactionError, "Insert User failed");
                        return result;
                    }
                    //sqlDataReader.Read();
                    //string id = Convert.ToString(sqlDataReader[0]);
                    //info.Id = id;
                    sqlDataReader.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    bool flag2 = ex.Message.Contains("PRIMARY KEY constraint");
            //    if (flag2)
            //    {
            //        result = new ReturnInfo(ErrorEnum.UniqueConstraint, string.Format("User {0} already exist in the system", info.Name));
            //        return result;
            //    }
                //result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
                //return result;
            //}
            result = new ReturnInfo(ErrorEnum.NoError, "", 1);
            return result;
        }

        public IInfo Update(SmartDB dbInstance, UserInfo info)
        {
            int rowsAffected = 0;
            SqlParameter[] updateParameters = this.GetUpdateParameters(dbInstance.Connection.ConnectionString);
            string cmdText = "REPORT USERINFO_UPD";
            updateParameters[0].Value = info.Id;
            updateParameters[1].Value = info.Username;
            updateParameters[2].Value = info.Password;
            updateParameters[3].Value = info.Name;
            updateParameters[4].Value = info.Role;
            updateParameters[5].Value = info.IsActive;
            IInfo result;
            //try
            //{
            //    bool transactionControl = dbInstance.TransactionControl;
            //    if (transactionControl)
            //    {
            //        rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Transaction, CommandType.StoredProcedure, cmdText, updateParameters);
            //    }
            //    else
            //    {
            rowsAffected = SqlHelper.ExecuteNonQuery(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, updateParameters);
                    //SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, cmdText, updateParameters);
                    //bool hasRows2 = sqlDataReader.HasRows;
                    //if (hasRows2)
                    //{
                    //    result = new ReturnInfo(ErrorEnum.TransactionError, "Update User failed");
                    //    return result;
                    //}
            
                    //sqlDataReader.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    bool flag2 = ex.Message.Contains("unique constraint");
            //    if (flag2)
            //    {
            //        result = new ReturnInfo(ErrorEnum.UniqueConstraint, string.Format("User {0} already exist in the system", info.Name));
            //        return result;
            //    }
            //    result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
            //    return result;
            //}
            result = new ReturnInfo(ErrorEnum.NoError, "", rowsAffected);
            return result;
        }

        public IInfo UpdateLoginStatus(SmartDB dbInstance, string userId, bool isLogin)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = SqlHelper.GetParameters(dbInstance.Connection.ConnectionString, "REPORT USERINFO_ISLOGIN_UPD");
            string cmdText = "REPORT USERINFO_ISLOGIN_UPD";
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

        public IInfo Delete(SmartDB dbInstance, string Id)
        {
            int rowsAffected = 0;
            string cmdText = "REPORT USERINFO_DEL";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@ID", SqlDbType.NVarChar)
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
            string cmdText = "REPORT USERINFO_DID";
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
            string cmdText = "REPORT USERINFO_GET_USER_ID";
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@USERID", SqlDbType.NVarChar)
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
            string cmdText = "REPORT USERINFO_GID";
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

        //public IInfo GetRecords(SmartDB dbInstance, out List<UserInfo> list)
        //{
        //    list = new List<UserInfo>();
        //    IInfo result;
        //    try
        //    {
        //        bool transactionControl = dbInstance.TransactionControl;
        //        if (transactionControl)
        //        {
        //            using (SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(dbInstance.Transaction, CommandType.StoredProcedure, "REPORT USERINFO_LST", new SqlParameter[0]))
        //            {
        //                while (sqlDataReader.Read())
        //                {
        //                    UserInfo item;
        //                    this.SetInfo(out item, sqlDataReader);
        //                    list.Add(item);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            using (SqlDataReader sqlDataReader2 = SqlHelper.ExecuteReader(dbInstance.Connection.ConnectionString, CommandType.StoredProcedure, "REPORT USERINFO_LST", new SqlParameter[0]))
        //            {
        //                while (sqlDataReader2.Read())
        //                {
        //                    UserInfo item2;
        //                    this.SetInfo(out item2, sqlDataReader2);
        //                    list.Add(item2);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result = new ReturnInfo(ErrorEnum.DataException, ex.Message);
        //        return result;
        //    }
        //    result = new ReturnInfo();
        //    return result;
        //}
        public IInfo GetRecords(SmartDB dbInstance, string cmdText, SqlParameter[] parms)
        {
            var list = new List<UserInfo>();
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
                        Model.UserInfo item;
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
    }
}
