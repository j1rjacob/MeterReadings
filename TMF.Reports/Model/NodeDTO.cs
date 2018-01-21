using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class NodeDTO : ModelInfo
    {
        public string City { get; set; }
        public string DMZ { get; set; }
        public string MacAddress { get; set; }
        public string SerialNumber { get; set; }

        public NodeDTO()
        {
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }
        public NodeDTO(string City, string DMZ, string MacAddress, string SerialNumber)
        {
            this.City = City;
            this.DMZ = DMZ;
            this.MacAddress = MacAddress;
            this.SerialNumber = SerialNumber;
            base.IsNew = false;
            base.IsDirty = true;
            base.IsDeleted = false;
        }

        protected override object OnGetValue(string fieldname)
        {
            switch (fieldname.ToLower())
            {
                case "city":
                    return City;
                    break;
                case "dmz":
                    return DMZ;
                    break;
                case "macaddress":
                    return MacAddress;
                    break;
                case "serialnumber":
                    return SerialNumber;
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
                case "city":
                    City = CastDBNull.To<string>(value, "");
                    break;
                case "dmz":
                    DMZ = CastDBNull.To<string>(value, "");
                    break;
                case "macaddress":
                    MacAddress = CastDBNull.To<string>(value, "");
                    break;
                case "serilnumber":
                    SerialNumber = CastDBNull.To<string>(value, "");
                    break;
                default:
                    //null;
                    break;
            }
        }
    }
    
}
