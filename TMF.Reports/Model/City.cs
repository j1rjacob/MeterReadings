using System;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class City : ModelInfo
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int TotalNumberOfMeters { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime DocDate { get; set; }
        public bool Show { get; set; }
        public int Lock_Count { get; set; }

        public City()
        {
            Id = "";
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }

        public City(string Id, string Description, int TotalNumberOfMeters, 
                    string CreatedBy, string EditedBy, DateTime DocDate,
                    bool Show, int LockCount)
        {
            this.Id = Id;
            this.Description = Description;
            this.TotalNumberOfMeters = TotalNumberOfMeters;
            this.CreatedBy = CreatedBy;
            this.EditedBy = EditedBy;
            this.DocDate = DocDate;
            this.Show = Show;
            this.Lock_Count = LockCount;
            base.IsNew = false;
            base.IsDirty = true;
            base.IsDeleted = false;
        }
    }
}
