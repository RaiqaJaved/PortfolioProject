using Microsoft.EntityFrameworkCore;
using Portfolioo.Model;

namespace Portfolioo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Contact> tbl_Contact { get; set; }
        public DbSet<Education> tbl_Education { get; set; }
        public DbSet<Experince> tbl_Experince { get; set; }
        public DbSet<Facts> tbl_Facts { get; set; }
        public DbSet<Profile> tbl_Profile { get; set; }
        public DbSet<services> tbl_Services { get; set; }
        public DbSet<Skills> tbl_Skills { get; set; }
        public DbSet<SocialNetworks> tbl_SocialNetworks { get; set; }
        public DbSet<Testamonia> tbl_Testamonial { get; set; }

    }
}
