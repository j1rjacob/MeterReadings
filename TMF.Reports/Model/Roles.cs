using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class Roles : ModelInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Roles()
        {
            Id = "";
        }
        public Roles(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        protected override object OnGetValue(string fieldname)
        {
            switch (fieldname.ToLower())
            {
                case "id":
                    return this.Id;
                    break;
                case "name":
                    return this.Name;
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
                case "name":
                    this.Name = CastDBNull.To<string>(value, "");
                    break;
                default:
                    //null;
                    break;
            }
        }
    }
}
