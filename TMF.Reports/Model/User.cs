using System;
using TMF.Core;
using TMF.Core.Model;

namespace TMF.Reports.Model
{
    public class User : ModelInfo
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime LockoutEndDateUtc { get; set; } 
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
public string RoleName { get; set; }
        public string UserName { get; set; }
        
       
        public User()
        {
            Id = "";
            base.IsNew = true;
            base.IsDirty = false;
            base.IsDeleted = false;
        }

        public User(string Id, string Email, bool EmailConfirmed, string PasswordHash,
                    string SecurityStamp, string PhoneNumber, bool TwoFactorEnabled,
                    DateTime LockoutEndDateUtc, bool LockoutEnabled, string RoleName, int AccessFailedCount, 
                    string UserName)
        {
            this.Id = Id;
            this.Email = Email;
            this.EmailConfirmed = EmailConfirmed;
            this.PasswordHash = PasswordHash;
            this.SecurityStamp = SecurityStamp;
            this.PhoneNumber = PhoneNumber;
            this.PhoneNumberConfirmed = PhoneNumberConfirmed;
            this.TwoFactorEnabled = TwoFactorEnabled;
            this.LockoutEndDateUtc = LockoutEndDateUtc;
            this.LockoutEnabled = LockoutEnabled;
            this.RoleName = RoleName;
            this.AccessFailedCount = AccessFailedCount;
            this.UserName = UserName;
            
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
                case "email":
                    return this.Email;
                    break;
                case "emailconfirmed":
                    return this.EmailConfirmed;
                    break;
                case "passwordhash":
                    return this.PasswordHash;
                    break;
                case "securitystamp":
                    return this.SecurityStamp;
                    break;
                case "phonenumber":
                    return this.PhoneNumber;
                    break;
                case "twofactorenabled":
                    return this.TwoFactorEnabled;
                    break;
                case "lockoutenddateutc":
                    return this.LockoutEndDateUtc;
                    break;
                case "lockoutenabled":
                    return this.LockoutEnabled;
                    break;
                case "accessfailedcount":
                    return this.AccessFailedCount;
                    break;
                case "username":
                    return this.UserName;
                    break;
                case "rolename":
                    return this.RoleName;
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
                case "email":
                    this.Email = CastDBNull.To<string>(value, "");
                    break;
                case "emailconfirmed":
                    this.EmailConfirmed = CastDBNull.To<bool>(value, true);
                    break;
                case "passwordhash":
                    this.PasswordHash = CastDBNull.To<string>(value, "");
                    break;
                case "securitystamp":
                    this.SecurityStamp = CastDBNull.To<string>(value, "");
                    break;
                case "phonenumber":
                    this.PhoneNumber = CastDBNull.To<string>(value, "");
                    break;
                case "twofactorenabled":
                    this.TwoFactorEnabled = CastDBNull.To<bool>(value, false);
                    break;
                case "lockoutenddateutc":
                    this.LockoutEndDateUtc = CastDBNull.To<DateTime>(value, DateTime.Now);
                    break;
                case "lockoutenabled":
                    this.LockoutEnabled = CastDBNull.To<bool>(value, false);
                    break;
                case "accessfailedcount":
                    this.AccessFailedCount = CastDBNull.To<int>(value, 0);
                    break;
                case "username":
                    this.UserName = CastDBNull.To<string>(value, "");
                    break;
                case "rolename":
                    this.RoleName = CastDBNull.To<string>(value, "");
                    break;
                default:
                    //null;
                    break;
            }
        }
    }
}
