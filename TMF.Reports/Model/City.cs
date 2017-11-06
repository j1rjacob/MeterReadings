using System;
using System.Collections;
using TMF.Core;
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
        public int Show { get; set; }
        public int LockCount { get; set; }

        public City()
        {
            Id = "";
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }

        public City(string Id, string Description, int TotalNumberOfMeters, 
                    string CreatedBy, string EditedBy, DateTime DocDate,
                    int Show, int LockCount)
        {
            this.Id = Id;
            this.Description = Description;
            this.TotalNumberOfMeters = TotalNumberOfMeters;
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
            //uint num = < PrivateImplementationDetails >.ComputeStringHash(text);

            object result;
            //if (num <= 1680044954u)
            //{
            //    if (num <= 926444256u)
            //    {
            //        if (num != 625445432u)
            //        {
            //            if (num == 926444256u)
            //            {
            //                if (text == "id")
            //                {
            //                    result = this.Id;
            //                    return result;
            //                }
            //            }
            //        }
            //        else if (text == "is_active")
            //        {
            //            result = this.Is_Active;
            //            return result;
            //        }
            //    }
            //    else if (num != 926946562u)
            //    {
            //        if (num != 1513905545u)
            //        {
            //            if (num == 1680044954u)
            //            {
            //                if (text == "access_group_description")
            //                {
            //                    result = this.Access_Group_Description;
            //                    return result;
            //                }
            //            }
            //        }
            //        else if (text == "created_by")
            //        {
            //            result = this.Created_By;
            //            return result;
            //        }
            //    }
            //    else if (text == "modified_by")
            //    {
            //        result = this.Modified_By;
            //        return result;
            //    }
            //}
            //else if (num <= 2446189534u)
            //{
            //    if (num != 1740645029u)
            //    {
            //        if (num != 1928175929u)
            //        {
            //            if (num == 2446189534u)
            //            {
            //                if (text == "lock_count")
            //                {
            //                    result = this.Lock_Count;
            //                    return result;
            //                }
            //            }
            //        }
            //        else if (text == "date_modified")
            //        {
            //            result = this.Date_Modified;
            //            return result;
            //        }
            //    }
            //    else if (text == "access_group_code")
            //    {
            //        result = this.Access_Group_Code;
            //        return result;
            //    }
            //}
            //else if (num != 3737921766u)
            //{
            //    if (num != 4098876561u)
            //    {
            //        if (num == 4187677609u)
            //        {
            //            if (text == "is_delete")
            //            {
            //                result = this.Is_Delete;
            //                return result;
            //            }
            //        }
            //    }
            //    else if (text == "remark")
            //    {
            //        result = this.Remark;
            //        return result;
            //    }
            //}
            //else if (text == "date_created")
            //{
            //    result = this.Date_Created;
            //    return result;
            //}
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
            if (text == "totalnumberofmeters")
            {
                result = this.TotalNumberOfMeters;
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
            //uint num = < PrivateImplementationDetails >.ComputeStringHash(text);
            
            //if (num <= 1680044954u)
            //{
            //    if (num <= 926444256u)
            //    {
            //        if (num != 625445432u)
            //        {
            //            if (num == 926444256u)
            //            {
            //                if (text == "id")
            //                {
            //                    this.Id = CastDBNull.To<int>(value, -1);
            //                }
            //            }
            //        }
            //        else if (text == "is_active")
            //        {
            //            this.Is_Active = CastDBNull.To<bool>(value, true);
            //        }
            //    }
            //    else if (num != 926946562u)
            //    {
            //        if (num != 1513905545u)
            //        {
            //            if (num == 1680044954u)
            //            {
            //                if (text == "access_group_description")
            //                {
            //                    this.Access_Group_Description = CastDBNull.To<string>(value, "");
            //                }
            //            }
            //        }
            //        else if (text == "created_by")
            //        {
            //            this.Created_By = CastDBNull.To<int>(value, 1);
            //        }
            //    }
            //    else if (text == "modified_by")
            //    {
            //        this.Modified_By = CastDBNull.To<int>(value, 1);
            //    }
            //}
            //else if (num <= 2446189534u)
            //{
            //    if (num != 1740645029u)
            //    {
            //        if (num != 1928175929u)
            //        {
            //            if (num == 2446189534u)
            //            {
            //                if (text == "lock_count")
            //                {
            //                    this.Lock_Count = CastDBNull.To<int>(value, 1);
            //                }
            //            }
            //        }
            //        else if (text == "date_modified")
            //        {
            //            this.Date_Modified = CastDBNull.To<DateTime>(value, DateTime.Now);
            //        }
            //    }
            //    else if (text == "access_group_code")
            //    {
            //        this.Access_Group_Code = CastDBNull.To<string>(value, "");
            //    }
            //}
            //else if (num != 3737921766u)
            //{
            //    if (num != 4098876561u)
            //    {
            //        if (num == 4187677609u)
            //        {
            //            if (text == "is_delete")
            //            {
            //                this.Is_Delete = CastDBNull.To<bool>(value, false);
            //            }
            //        }
            //    }
            //    else if (text == "remark")
            //    {
            //        this.Remark = CastDBNull.To<string>(value, "");
            //    }
            //}
            //else if (text == "date_created")
            //{
            //    this.Date_Created = CastDBNull.To<DateTime>(value, DateTime.Now);
            //}

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
                this.TotalNumberOfMeters = CastDBNull.To<int>(value, 0);
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
                this.TotalNumberOfMeters = CastDBNull.To<int>(value, 0);
            }
        }
    }

}

