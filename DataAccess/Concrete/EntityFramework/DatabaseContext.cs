using Core;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<DailyData> DailyDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigSettings.ConnectionString);
        }
    }
}
