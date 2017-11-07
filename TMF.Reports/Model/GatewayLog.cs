using System;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class GatewayLog : ModelInfo 
    {
        public string Id { get; set; }
        public DateTime LogDateTime { get; set; }
        public int MeterRAWCount { get; set; }
        public int MeterOMSCount { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime DocDate { get; set; }
        public int Show { get; set; }
        public int LockCount { get; set; }
        public GatewayLog()
        {
            Id = "";
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }

        public GatewayLog(string Id, DateTime LogDateTime, int MeterRAWCount,
                          int MeterOMSCount, string CreatedBy, string EditedBy,
                          DateTime DocDate, int Show, int LockCount)
        {
            this.Id = Id;
            this.LogDateTime = LogDateTime;
            this.MeterRAWCount = MeterRAWCount;
            this.MeterOMSCount = MeterOMSCount;
            this.CreatedBy = CreatedBy;
            this.EditedBy = EditedBy;
            this.DocDate = DocDate;
            this.Show = Show;
            this.LockCount = LockCount;
        }
        protected override object OnGetValue(string fieldname)
        {
            switch (fieldname.ToLower())
            {
                case "id":
                    return this.Id;
                    break;
                case "logdatetime":
                    return this.LogDateTime;
                    break;
                case "meterrawcount":
                    return this.MeterRAWCount;
                    break;
                case "meteromscount":
                    return this.MeterOMSCount;
                    break;
                case "createdby":
                    return this.CreatedBy;
                    break;
                case "editedby":
                    return this.EditedBy;
                    break;
                case "docdate":
                    return this.DocDate;
                    break;
                case "show":
                    return this.Show;
                    break;
                case "lockcount":
                    return this.LockCount;
                    break;
                default:
                    return null;
                    break;
            }
        }
        protected override void OnSetValue(string fieldname, object value)
        {
            switch (fieldname.ToLower())
            {
                case "id":
                    this.Id = CastDBNull.To<string>(value, "");
                    break;
                case "logdatetime":
                    this.LogDateTime = CastDBNull.To<DateTime>(value, DateTime.Now);
                    break;
                case "meterrawcount":
                    this.MeterRAWCount = CastDBNull.To<int>(value, 0);
                    break;
                case "meteromscount":
                    this.MeterOMSCount = CastDBNull.To<int>(value, 0);
                    break;
                case "createdby":
                    this.CreatedBy = CastDBNull.To<string>(value, "");
                    break;
                case "editedby":
                    this.EditedBy = CastDBNull.To<string>(value, "");
                    break;
                case "docdate":
                    this.DocDate = CastDBNull.To<DateTime>(value, DateTime.Now);
                    break;
                case "show":
                    this.Show = CastDBNull.To<int>(value, 0);
                    break;
                case "lockcount":
                    this.LockCount = CastDBNull.To<int>(value, 0);
                    break;
                default:
                    //null;
                    break;
            }
        }
    }
}
