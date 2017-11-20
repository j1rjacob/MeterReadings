using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;

namespace TMF.Reports.Model
{
    public class CustomUserDbContext : DbContext
    {
        public CustomUserDbContext() : base("DefaultConnection") { }
        public DbSet<CustomUser> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var user = modelBuilder.Entity<CustomUser>();
            user.ToTable("Users");
            user.HasKey(x => x.Id);
            user.Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            user.Property(x => x.UserName).IsRequired().HasMaxLength(256)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UserNameIndex") { IsUnique = true }));

            base.OnModelCreating(modelBuilder);
        }
    }
}
