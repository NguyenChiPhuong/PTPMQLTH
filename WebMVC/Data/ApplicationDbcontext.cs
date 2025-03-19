using Microsoft.EntityFrameworkCore;
using WebMvc.Models;
using WebMVC.Models;

namespace WebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<DaiLy> DaiLy { get; set; }
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; }
        
        public DbSet<DaiLy1> Daily1 { get; set; }
        public DbSet<HeThongPhanPhoi1> HeThongPhanPhoi1 { get; set; }
    }
}