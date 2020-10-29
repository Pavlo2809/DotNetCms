using DotNetCms.Domain.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DotNetCms.DataLayer
{
    public class DotNetCMSContext : DbContext
    {
        public DotNetCMSContext(DbContextOptions<DotNetCMSContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Human> Humans { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Possition> Possitions { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CarouselItem> CarouselItems { get; set; }


    }
}