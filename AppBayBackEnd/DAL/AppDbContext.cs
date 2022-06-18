using AppBayBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBayBackEnd.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        public DbSet<Slider>Slider { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<Modern> ModernCard { get; set; }
    }
}
