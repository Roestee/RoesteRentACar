using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Persistence.Context
{
    public class RentACarDbContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDescription> VehicleDescriptions { get; set; }
        public DbSet<VehicleFeature> VehicleFeatures { get; set; }
        public DbSet<VehiclePricing> VehiclePricings { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ibrahim-pc\\SQLEXPRESS;Database=RentACarDb;User Id=degerkaybi;Password=SSii8501.DD,;Encrypt=False;");
        }
    }
}
