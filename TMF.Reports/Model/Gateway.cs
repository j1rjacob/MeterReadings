using System;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class Gateway : ModelInfo
    {
        public string MacAddress { get; set; }
        public string SimCard { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public string Description { get; set; }
        public DateTime InstallationDate { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Status { get; set; }
        public string IPAddress { get; set; }
        public string DMZId { get; set; }
        public string CityId { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime DocDate { get; set; }
        public int Show { get; set; }
        public int LockCount { get; set; }

        public Gateway()
        {
            MacAddress = "";
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }

        public Gateway(string MacAddress, string SimCard,
            decimal X, decimal Y, string Description,
            DateTime InstallationDate, DateTime MaintenanceDate,
            string Status, string IPAddress, string DMZId,
            string CityId, string CreatedBy, string EditedBy,
            DateTime DocDate, int Show, int LockCount)
        {
            this.MacAddress = MacAddress;
            this.SimCard = SimCard;
            this.X = X;
            this.Y = Y;
            this.Description = Description;
            this.InstallationDate = InstallationDate;
            this.MaintenanceDate = MaintenanceDate;
            this.Status = Status;
            this.IPAddress = IPAddress;
            this.DMZId = DMZId;
            this.CityId = CityId;
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
                case "macaddress":
                    return this.MacAddress;
                    break;
                case "simcard":
                    return this.SimCard;
                    break;
                case "x":
                    return this.X;
                    break;
                case "y":
                    return this.Y;
                    break;
                case "description":
                    return this.Description;
                    break;
                case "installationdate":
                    return this.InstallationDate;
                    break;
                case "maintenancedate":
                    return this.MaintenanceDate;
                    break;
                case "status":
                    return this.Status;
                    break;
                case "ipaddress":
                    return this.IPAddress;
                    break;
                case "dmzid":
                    return this.DMZId;
                    break;
                case "cityid":
                    return this.CityId;
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
                case "macaddress":
                    this.MacAddress = CastDBNull.To<string>(value, "");
                    break;
                case "simcard":
                    this.SimCard = CastDBNull.To<string>(value, "");
                    break;
                case "x":
                    this.X = CastDBNull.To<decimal>(value, 0.0m);
                    break;
                case "y":
                    this.Y = CastDBNull.To<decimal>(value, 0.0m);
                    break;
                case "description":
                    this.Description = CastDBNull.To<string>(value, "");
                    break;
                case "installationdate":
                    this.InstallationDate = CastDBNull.To<DateTime>(value, DateTime.Now);
                    break;
                case "maintenancedate":
                    this.MaintenanceDate = CastDBNull.To<DateTime>(value, DateTime.Now);
                    break;
                case "status":
                    this.Status = CastDBNull.To<string>(value, "");
                    break;
                case "ipaddress":
                    this.IPAddress = CastDBNull.To<string>(value, "");
                    break;
                case "dmzid":
                    this.DMZId = CastDBNull.To<string>(value, "");
                    break;
                case "cityid":
                    this.CityId = CastDBNull.To<string>(value, "");
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
