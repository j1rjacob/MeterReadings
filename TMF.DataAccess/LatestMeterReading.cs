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
    
    public partial class LatestMeterReading
    {
        public System.Guid Id { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<System.DateTime> ReadingDate { get; set; }
        public string ReadingValue { get; set; }
        public Nullable<int> LowBatteryAlr { get; set; }
        public Nullable<int> LeakAlr { get; set; }
        public Nullable<int> MagneticTamperAlr { get; set; }
        public Nullable<int> MeterErrorAlr { get; set; }
        public Nullable<int> BackFlowAlr { get; set; }
        public Nullable<int> BrokenPipeAlr { get; set; }
        public Nullable<int> EmptyPipeAlr { get; set; }
        public Nullable<int> SpecificErr { get; set; }
        public string Createdby { get; set; }
        public string Editedby { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<int> Show { get; set; }
        public Nullable<int> LockCount { get; set; }
    }
}
