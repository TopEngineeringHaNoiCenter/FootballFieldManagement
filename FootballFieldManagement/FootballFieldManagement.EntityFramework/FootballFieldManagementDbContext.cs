using FootballFieldManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFieldManagement.EntityFramework
{
    public class FootballFieldManagementDbContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public FootballFieldManagementDbContext(DbContextOptions options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
