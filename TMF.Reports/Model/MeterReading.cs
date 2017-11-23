﻿using System;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class MeterReading : ModelInfo 
    {
        public string Id { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ReadingDate { get; set; }
        public string CSVType { get; set; }
        public string ReadingValue { get; set; }
        public string Description { get; set; }
        public int LowBatteryAlr { get; set; }
        public int LeakAlr { get; set; }
        public int MagneticTamperAlr { get; set; }
        public int MeterErrorAlr { get; set; }
        public int BackFlowAlr { get; set; }
        public int BrokenPipeAlr { get; set; }
        public int EmptyPipeAlr { get; set; }
        public int SpecificErr { get; set; }
        public int FlowRateValue { get; set; }
        public int AppBusyAlr { get; set; }
        public int AnyAppErrorAlr { get; set; }
        public int AbnormalConditionAlr { get; set; }
        public int PermanentErrorAlr { get; set; }
        public int TemporaryErrorAlr { get; set; }
        public int SpecificError1Alr { get; set; }
        public int SpecificError2Alr { get; set; }
        public int SpecificError3Alr { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime DocDate { get; set; }
        public int Show { get; set; }
        public int LockCount { get; set; }
        public MeterReading()
        {
            Id = "";
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }
        public MeterReading(string Id, string SerialNumber, DateTime ReadingDate,
                            string CSVType, string ReadingValue, string Description, int LowBatteryAlr,
                            int LeakAlr, int MagneticTamperAlr, int MeterErrorAlr,
                            int BackFlowAlr, int BrokenPipeAlr, int EmptyPipeAlr,
                            int SpecificErr, int FlowRateValue, int AppBusyAlr,
                            int AnyAppErrorAlr, int AbnormalConditionAlr, int PermanentErrorAlr,
                            int TemporaryErrorAlr, int SpecificError1Alr, int SpecificError2Alr,
                            int SpecificError3Alr, string CreatedBy, string EditedBy,
                            DateTime DocDate, int Show, int LockCount)
        {
            this.Id = Id;
            this.SerialNumber = SerialNumber;
            this.ReadingDate = ReadingDate;
            this.CSVType =CSVType;
            this.ReadingValue=ReadingValue;
            this.LowBatteryAlr=LowBatteryAlr;
            this.LeakAlr=LeakAlr;
            this.MagneticTamperAlr=MagneticTamperAlr;
            this.MeterErrorAlr=MeterErrorAlr;
            this.BackFlowAlr=BackFlowAlr;
            this.BrokenPipeAlr=BrokenPipeAlr;
            this.EmptyPipeAlr=EmptyPipeAlr;
            this.SpecificErr=SpecificErr;
            this.FlowRateValue=FlowRateValue;
            this.AppBusyAlr=AppBusyAlr;
            this.AnyAppErrorAlr=AnyAppErrorAlr;
            this.AbnormalConditionAlr=AbnormalConditionAlr;
            this.PermanentErrorAlr=PermanentErrorAlr;
            this.TemporaryErrorAlr= TemporaryErrorAlr;
            this.SpecificError1Alr= SpecificError1Alr;
            this.SpecificError2Alr= SpecificError2Alr;
            this.SpecificError3Alr = SpecificError3Alr;
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
                case "serialnumber":
                    return this.SerialNumber;
                    break;
                case "readingdate":
                    return this.ReadingDate;
                    break;
                case "csvtype":
                    return this.CSVType;
                    break;
                case "readingvalue":
                    return this.ReadingValue;
                    break;
                case "description":
                    return this.Description;
                    break;
                case "lowbatteryalr":
                    return this.LowBatteryAlr;
                    break;
                case "leakalr":
                    return this.LeakAlr;
                    break;
                case "magnetictamperalr":
                    return this.MagneticTamperAlr;
                    break;
                case "metererroralr":
                    return this.MeterErrorAlr;
                    break;
                case "backflowalr":
                    return this.BackFlowAlr;
                    break;
                case "brokenpipealr":
                    return this.BrokenPipeAlr;
                    break;
                case "emptypipealr":
                    return this.EmptyPipeAlr;
                    break;
                case "specificerr":
                    return this.SpecificErr;
                    break;
                case "flowratevalue":
                    return this.FlowRateValue;
                    break;
                case "appbusyalr":
                    return this.AppBusyAlr;
                    break;
                case "anyapperroralr":
                    return this.AnyAppErrorAlr;
                    break;
                case "abnormalconditionalr":
                    return this.AbnormalConditionAlr;
                    break;
                case "permanenterroralr":
                    return this.PermanentErrorAlr;
                    break;
                case "temporaryerroralr":
                    return this.TemporaryErrorAlr;
                    break;
                case "specificerror1alr":
                    return this.SpecificError1Alr;
                    break;
                case "specificerror2alr":
                    return this.SpecificError2Alr;
                    break;
                case "specificerror3alr":
                    return this.SpecificError3Alr;
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
                case "serialnumber":
                    this.SerialNumber = CastDBNull.To<string>(value, "");
                    break;
                case "readingdate":
                    this.ReadingDate = CastDBNull.To<DateTime>(value, DateTime.Now);
                    break;
                case "csvtype":
                    this.CSVType = CastDBNull.To<string>(value, "");
                    break;
                case "readingvalue":
                    this.ReadingValue = CastDBNull.To<string>(value, "");
                    break;
                case "description":
                    this.Description = CastDBNull.To<string>(value, "");
                    break;
                case "lowbatteryalr":
                    this.LowBatteryAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "leakalr":
                    this.LeakAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "magnetictamperalr":
                    this.MagneticTamperAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "metererroralr":
                    this.MeterErrorAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "backflowalr":
                    this.BackFlowAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "brokenpipealr":
                    this.BrokenPipeAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "emptypipealr":
                    this.EmptyPipeAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "specificerr":
                    this.SpecificErr = CastDBNull.To<int>(value, 0);
                    break;
                case "flowratevalue":
                    this.FlowRateValue = CastDBNull.To<int>(value, 0);
                    break;
                case "appbusyalr":
                    this.AppBusyAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "anyapperroralr":
                    this.AnyAppErrorAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "abnormalconditionalr":
                    this.AbnormalConditionAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "permanenterroralr":
                    this.PermanentErrorAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "temporaryerroralr":
                    this.TemporaryErrorAlr = CastDBNull.To<int>(value, 0);
                    break;
                case "specificerror1alr":
                    this.SpecificError1Alr = CastDBNull.To<int>(value, 0);
                    break;
                case "specificerror2alr":
                    this.SpecificError2Alr = CastDBNull.To<int>(value, 0);
                    break;
                case "specificerror3alr":
                    this.SpecificError3Alr = CastDBNull.To<int>(value, 0);
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
