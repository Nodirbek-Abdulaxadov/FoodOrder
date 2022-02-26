﻿using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.DataLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base (options)
        {

        }

        public DbSet<Kategoriya> Kategoriyalar { get; set; }
        public DbSet<Mahsulot> Mahsulotlar { get; set; }
    }
}
