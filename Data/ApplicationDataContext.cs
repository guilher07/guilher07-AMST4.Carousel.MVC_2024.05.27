﻿using AMST4.Carousel.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AMST4.Carousel.MVC.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Size> Size { get; set; } 
    }
}
