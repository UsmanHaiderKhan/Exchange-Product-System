using EPSClassLibrary.LocationMgmt;
using EPSClassLibrary.ProductMgmt;
using EPSClassLibrary.BannerMgmt;
using System.Data.Entity;
using EPSClassLibrary.UserMgmt;

namespace EPSClassLibrary
{
    public class DBContextClass : DbContext
    {
        public DBContextClass() : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImages> ProductImages { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<MainBanner> MainBanners { get; set; }

        public DbSet<Messages> Messages { get; set; }

        public DbSet<Converstion> Converstions { get; set; }

    }
}
