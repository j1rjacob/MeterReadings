//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMF.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meter
    {
        public string SerialNumber { get; set; }
        public Nullable<decimal> X { get; set; }
        public Nullable<decimal> Y { get; set; }
        public string Status { get; set; }
        public string HCN { get; set; }
        public Nullable<System.DateTime> InstallationDate { get; set; }
        public Nullable<System.DateTime> MaintenanceDate { get; set; }
        public Nullable<int> MeterTypeId { get; set; }
        public Nullable<int> MeterSizeId { get; set; }
        public Nullable<int> MeterProtocolId { get; set; }
        public Nullable<int> DMZId { get; set; }
        public string CityId { get; set; }
        public string MacAddress { get; set; }
        public string Createdby { get; set; }
        public string Editedby { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<int> Show { get; set; }
        public Nullable<int> LockCount { get; set; }
    }
}
