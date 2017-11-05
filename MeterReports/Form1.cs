using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Windows.Forms;

namespace MeterReports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            //var creationResult = userManager.Create(new IdentityUser("j1rjacob"), "Password123!");
            //MessageBox.Show($"Created: {creationResult}");

            var user = userManager.FindByName("j1rjacob");
            var claimResult = userManager.AddToRole(user.Id, "Administrator");
            MessageBox.Show($"Claim Added: {claimResult.Succeeded}");

            //var roleStore = new RoleStore<IdentityRole>();
            //var roleManager = new RoleManager<IdentityRole>(roleStore);

            //var roleResult = roleManager.Create(new IdentityRole { Name = "Administrator" });
            //MessageBox.Show($"Role Added: {roleResult.Succeeded}");
        }
    }
}