using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;initial Catalog=SignalRDb;integrated security=true;encrypt=false;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }    
        public DbSet<Contact> Contacts { get; set; }    
        public DbSet<Category> Categories { get; set; } 
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;} 
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }    
        public DbSet<Discount> Discounts { get; set; }  

    }
}
