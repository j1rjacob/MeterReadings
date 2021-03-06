﻿using System;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class DMZ : ModelInfo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TotalNumberOfMeters { get; set; }
        public string CityId { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime DocDate { get; set; }
        public int Show { get; set; }
        public int LockCount { get; set; }
        public DMZ()
        {
            Id = 0;
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }
        public DMZ(int Id, string Description, int TotalNumberOfMeters, string CityId,
                   string Type, string CreatedBy, string EditedBy, DateTime DocDate,
                   int Show, int LockCount)
        {
            this.Id = Id;
            this.Description = Description;
            this.TotalNumberOfMeters = TotalNumberOfMeters;
            this.CityId = CityId;
            this.Type = Type;
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
                case "id":
                    return this.Id;
                    break;
                case "description":
                    return this.Description;
                    break;
                case "totalnumberofmeters":
                    return this.TotalNumberOfMeters;
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
                case "id":
                    this.Id = CastDBNull.To<int>(value, 0);
                    break;
                case "description":
                    this.Description = CastDBNull.To<string>(value, "");
                    break;
                case "totalnumberofmeters":
                    this.TotalNumberOfMeters = CastDBNull.To<int>(value, 0);
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
                    this.TotalNumberOfMeters = CastDBNull.To<int>(value, 0);
                    break;
                default:
                    //null;
                    break;
            }
        }
    }
}
