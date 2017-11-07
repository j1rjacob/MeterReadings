﻿using System;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class MeterType : ModelInfo
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime DocDate { get; set; }
        public int Show { get; set; }
        public int LockCount { get; set; }

        public MeterType()
        {
            Id = "";
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }

        public MeterType(string Id, string Description, string CreatedBy, string EditedBy,
                         DateTime DocDate, int Show, int LockCount)
        {
            this.Id = Id;
            this.Description = Description;
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
            string text = fieldname.ToLower();
           
            object result;
            
            if (text == "id")
            {
                result = this.Id;
                return result;
            }
            if (text == "description")
            {
                result = this.Description;
                return result;
            }
            if (text == "createdby")
            {
                result = this.CreatedBy;
                return result;
            }
            if (text == "editedby")
            {
                result = this.EditedBy;
                return result;
            }
            if (text == "docdate")
            {
                result = this.DocDate;
                return result;
            }
            if (text == "show")
            {
                result = this.Show;
                return result;
            }
            if (text == "lockcount")
            {
                result = this.LockCount;
                return result;
            }

            result = null;

            return result;
        }

        protected override void OnSetValue(string fieldname, object value)
        {
            string text = fieldname.ToLower();
            
            if (text == "id")
            {
                this.Id = CastDBNull.To<string>(value, "");
            }

            if (text == "description")
            {
                this.Description = CastDBNull.To<string>(value, "");
            }
            if (text == "totalnumberofmeters")
            {
                //this.TotalNumberOfMeters = CastDBNull.To<int>(value, 0);
            }
            if (text == "createdby")
            {
                this.CreatedBy = CastDBNull.To<string>(value, "");
            }
            if (text == "editedby")
            {
                this.EditedBy = CastDBNull.To<string>(value, "");
            }
            if (text == "docdate")
            {
                this.DocDate = CastDBNull.To<DateTime>(value, DateTime.Now);
            }
            if (text == "show")
            {
                this.Show = CastDBNull.To<int>(value, 0);
            }
            if (text == "lockcount")
            {
                //this.TotalNumberOfMeters = CastDBNull.To<int>(value, 0);
            }
        }
    }
}
