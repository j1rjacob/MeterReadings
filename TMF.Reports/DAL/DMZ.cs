using TMF.Core;

namespace TMF.Reports.DAL
{
    public class DMZ : BaseDAL
    {
        public DMZ()
        {
            SQL_DELETE = "[REPORT DMZ_DEL]";
            SQL_GET = "[REPORT DMZ_GET]";
            SQL_GET_LIST = "[REPORT DMZ_LST]";
            SQL_INSERT = "[REPORT DMZ_INS]";
            SQL_UPDATE = "[REPORT DMZ_UPD]";
            PARM_ID = "@Id";
        }

        //protected void SetInfo(out Model.DMZ info, SqlDataReader reader)
        //{
            //try
            //{
            //    info = new Model.DMZ();
            //    info.Id = CastDBNull.To<string>(reader["Id"], "");
            //    info.Description = CastDBNull.To<string>(reader["Description"], "");
            //    info.TotalNumberOfMeters = CastDBNull.To<int>(reader["TotalNumberOfMeters"], 0);
            //    info.CreatedBy = CastDBNull.To<string>(reader["Createdby"], "");
            //    info.EditedBy = CastDBNull.To<string>(reader["Editedby"], "");
            //    info.DocDate = CastDBNull.To<DateTime>(reader["DocDate"], DateTime.Now);
            //    info.Show = CastDBNull.To<int>(reader["Show"], 1);
            //    info.IsNew = false;
            //    info.IsDirty = true;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        //}
    }
}
