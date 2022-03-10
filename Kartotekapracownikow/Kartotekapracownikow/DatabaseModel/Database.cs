using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace Kartotekapracownikow.DatabaseModel
{
    public class Database : DbContext
    {
        
        public DbSet<DanePracownikaPodstawowe> DanePracownikaPodstawowe { get; set; }
        public DbSet<DanePracownikaZatrudnienie> DanePracownikaZatrudnienie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-173Q94A\SQLEXPRESS;Database=KartotekaPracownikow;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanePracownikaPodstawowe>()
                .HasOne(a => a.danePracownikaZatrudnienie)
                .WithOne(b => b.danePracownika)
                .HasForeignKey<DanePracownikaZatrudnienie>(b => b.podstawoweRef);
        }

    }
}
