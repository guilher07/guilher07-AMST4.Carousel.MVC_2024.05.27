using AMST4.Carousel.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AMST4.Carousel.MVC.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> opts) : base(opts)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
