using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;
using TMF.Reports.Model;

namespace TMF.Reports.BLL
{
    public class CustomUserStore : IUserPasswordStore<CustomUser, int>
    {
        private readonly CustomUserDbContext context;

        public CustomUserStore(CustomUserDbContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public Task CreateAsync(CustomUser user)
        {
            context.Users.Add(user);
            return context.SaveChangesAsync();
        }

        public Task UpdateAsync(CustomUser user)
        {
            context.Users.AddOrUpdate(user);
            return context.SaveChangesAsync();
        }

        public Task DeleteAsync(CustomUser user)
        {
            context.Users.Remove(user);
            return context.SaveChangesAsync();
        }

        public Task<CustomUser> FindByIdAsync(int userId)
        {
            return context.Users.FirstOrDefaultAsync(x => x.Id == userId);
        }

        public Task<CustomUser> FindByNameAsync(string userName)
        {
            return context.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }

        public Task SetPasswordHashAsync(CustomUser user, string passwordHash)
        {
            user.PasswordHash = passwordHash;
            return Task.CompletedTask;
        }

        public Task<string> GetPasswordHashAsync(CustomUser user)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(CustomUser user)
        {
            return Task.FromResult(user.PasswordHash != null);
        }
    }
}
