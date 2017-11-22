using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class User : ModelInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Locked { get; set; }
       
        public User()
        {
            Id = 0;
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }

        public User(int Id, string UserName, string PasswordHash, 
                    string FullName, string Role, string Locked)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.PasswordHash = PasswordHash;
            this.FullName = FullName;
            this.Role = Role;
            this.Locked = Locked;
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
                case "username":
                    return this.UserName;
                    break;
                case "passwordhash":
                    return this.PasswordHash;
                    break;
                case "fullname":
                    return this.FullName;
                    break;
                case "role":
                    return this.Role;
                    break;
                case "locked":
                    return this.Locked;
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
                case "username":
                    this.UserName = CastDBNull.To<string>(value, "");
                    break;
                case "passwordhash":
                    this.PasswordHash = CastDBNull.To<string>(value, "");
                    break;
                case "fullname":
                    this.FullName = CastDBNull.To<string>(value, "");
                    break;
                case "role":
                    this.Role = CastDBNull.To<string>(value, "");
                    break;
                case "locked":
                    this.Locked = CastDBNull.To<string>(value, "");
                    break;
                default:
                    //null;
                    break;
            }
        }
    }
}
