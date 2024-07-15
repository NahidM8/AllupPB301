using AllupPB301.Models;
using Microsoft.EntityFrameworkCore;

namespace AllupPB301.Data
{
    public class AllUpDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public AllUpDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
