﻿using System;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class Meter : ModelInfo
    {
        public string SerialNumber { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public string Status { get; set; }
        public string HCN { get; set; }
        public DateTime InstallationDate { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string MeterTypeId { get; set; }
        public string MeterSizeId { get; set; }
        public string MeterProtocolId { get; set; }
        public string DMZId { get; set; }
        public string CityId { get; set; }
        public string MacAddress { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime DocDate { get; set; }
        public int Show { get; set; }
        public int LockCount { get; set; }
        public Meter()
        {
            SerialNumber = "";
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }
        public Meter(string SerialNumber, decimal X, decimal Y, string Status,
                     string HCN, DateTime InstallationDate, DateTime MaintenanceDate,
                     string MeterTypeId, string MeterSizeId, string MeterProtocolId,
                     string DMZId, string CityId, string MacAddress, string CreatedBy,
                     string EditedBy, DateTime DocDate, int Show, int LockCount)
        {
            this.SerialNumber = SerialNumber;
            this.X = X;
            this.Y = Y;
            this.Status = Status;
            this.HCN = HCN;
            this.InstallationDate = InstallationDate;
            this.MaintenanceDate = MaintenanceDate;
            this.MeterTypeId = MeterTypeId;
            this.MeterSizeId = MeterSizeId;
            this.MeterProtocolId = MeterProtocolId;
            this.DMZId = DMZId;
            this.CityId = CityId;
            this.MacAddress = MacAddress;
            this.CreatedBy = CreatedBy;
            this.EditedBy = EditedBy;
            this.DocDate = DocDate;
            this.Show = Show;
            this.LockCount = LockCount;
            base.IsNew = false;
            base.IsDirty = true;
            base.IsDeleted = false;
        }
        protected override object OnGetValue(string fieldname)
        {
            switch (fieldname.ToLower())
            {
                case "serialnumber":
                    return this.SerialNumber;
                    break;
                case "x":
                    return this.X;
                    break;
                case "y":
                    return this.Y;
                    break;
                case "status":
                    return this.Status;
                    break;
                case "hcn":
                    return this.HCN;
                    break;
                case "installationdate":
                    return this.InstallationDate;
                    break;
                case "maintenancedate":
                    return this.MaintenanceDate;
                    break;
                case "metertypeid":
                    return this.MeterTypeId;
                    break;
                case "metersizeid":
                    return this.MeterSizeId;
                    break;
                case "meterprotocolid":
                    return this.MeterProtocolId;
                    break;
                case "dmzid":
                    return this.DMZId;
                    break;
                case "cityid":
                    return this.CityId;
                    break;
                case "macaddress":
                    return this.MacAddress;
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
                case "serialnumber":
                    this.SerialNumber = CastDBNull.To<string>(value, "");
                    break;
                case "x":
                    this.X = CastDBNull.To<decimal>(value, 0);
                    break;
                case "y":
                    this.Y = CastDBNull.To<decimal>(value, 0);
                    break;
                case "status":
                    this.Status = CastDBNull.To<string>(value, "");
                    break;
                case "hcn":
                    this.HCN = CastDBNull.To<string>(value, "");
                    break;
                case "installationdate":
                    this.InstallationDate = CastDBNull.To<DateTime>(value, DateTime.Now);
                    break;
                case "maintenancedate":
                    this.MaintenanceDate = CastDBNull.To<DateTime>(value, DateTime.Now);
                    break;
                case "metertypeid":
                    this.MeterTypeId = CastDBNull.To<string>(value, "");
                    break;
                case "metersizeid":
                    this.MeterSizeId = CastDBNull.To<string>(value, "");
                    break;
                case "meterprotocolid":
                    this.MeterProtocolId = CastDBNull.To<string>(value, "");
                    break;
                case "dmzid":
                    this.DMZId = CastDBNull.To<string>(value, "");
                    break;
                case "cityid":
                    this.CityId = CastDBNull.To<string>(value, "");
                    break;
                case "macaddress":
                    this.MacAddress = CastDBNull.To<string>(value, "");
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
