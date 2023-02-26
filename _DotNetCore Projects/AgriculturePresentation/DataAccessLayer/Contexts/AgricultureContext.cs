using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=/.;database=DbAgriculture;integrated security=true");
        }

        public DbSet<Address> addresses { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Image> ımages { get; set; }
        public DbSet<Announcement> announcements { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<About> abouts { get; set; }
        public DbSet<Admin> admins { get; set; }


    }
}
