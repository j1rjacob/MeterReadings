using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TMF.Reports.BLL
{
    public static class User
    {
        public static bool CheckPassword(string Username, string Password)
        {
            var userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>());
            var user = userManager.FindByName(Username);
            var checkPassword = userManager.CheckPassword(user, Password);
            return checkPassword;
        }
    }
}
