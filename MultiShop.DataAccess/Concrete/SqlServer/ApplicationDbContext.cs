using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultiShop.Core.Entities.Concrete;
using MultiShop.Entities.Concrete;

namespace MultiShop.DataAccess.Concrete.SqlServer
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=DESKTOP-LES9OTM; Initial Catalog=K220MultiShopDb; Trusted_Connection=true; MultipleActiveResultSets=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<CategorySubs> CategorySubs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("User");
            builder.Entity<IdentityRole>().ToTable("Roles");
        }
    }
}
