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
    
    public partial class GatewayLog
    {
        public System.Guid Id { get; set; }
        public Nullable<int> RDS { get; set; }
        public Nullable<int> OMS { get; set; }
        public string GatewayMacAddress { get; set; }
        public string CSVFilename { get; set; }
        public string Createdby { get; set; }
        public string Editedby { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public Nullable<int> Show { get; set; }
        public Nullable<int> LockCount { get; set; }
    }
}
