using Microsoft.EntityFrameworkCore;

namespace Sample_MVCWebApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AddressViewModel> Addresses { get; set; }

        public DbSet<NoticeViewModel> Notices { get; set; }
    }
}
