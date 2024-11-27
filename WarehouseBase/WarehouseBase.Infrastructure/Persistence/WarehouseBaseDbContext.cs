using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WarehouseBase.Domain.Entities;

namespace WarehouseBase.Infrastructure.Persistence
{
    public class WarehouseBaseDbContext:DbContext
    {
        public WarehouseBaseDbContext(DbContextOptions<WarehouseBaseDbContext> options):base(options)
        {
            
        }
        public DbSet<BaseRecord> BaseRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Domain.Entities.BaseRecord>();
        }
    }
}
