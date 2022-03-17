using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Logging;

namespace Kartotekapracownikow.DatabaseModel
{
    public class Database : DbContext
    {

        public DbSet<DanePracownikaPodstawowe> DanePracownikaPodstawowe { get; set; }
        public DbSet<DanePracownikaZatrudnienie> DanePracownikaZatrudnienie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            try
            {
                optionsBuilder.UseMySQL($"server=localhost;Port=3306;database=kartoteka-pracownicza;user=root;password=SonyW990");               
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Błąd podczas nawiązywania połączenia z bazą danych");
                        break;

                    case 1045:
                        MessageBox.Show("Nieprawidłowy login lub hasło do bazy danych");
                        break;
                }
            }
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DanePracownikaPodstawowe>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Nazwisko).IsRequired();
                entity.Property(e => e.Imie).IsRequired();
                entity.Property(e => e.ZdjeciePracownika).IsRequired();
                entity.Property(e => e.DataUrodzenia).IsRequired();
                entity.Property(e => e.NumerTelefonu).IsRequired();
                entity.Property(e => e.AdresEmail).IsRequired();
                entity.Property(e => e.MiejsceUrodzenia).IsRequired();
                entity.Property(e => e.Plec).IsRequired();
                entity.Property(e => e.ImieMatki).IsRequired();
                entity.Property(e => e.ImieOjca).IsRequired();
                entity.Property(e => e.PESEL).IsRequired();
                entity.Property(e => e.NIP).IsRequired();
                entity.Property(e => e.Kraj).IsRequired();
                entity.Property(e => e.Wojewodztwo).IsRequired();
                entity.Property(e => e.Gmina).IsRequired();
                entity.Property(e => e.KodZamieszkania).IsRequired();
                entity.Property(e => e.Miejscowosc).IsRequired();
                entity.Property(e => e.Ulica).IsRequired();
                entity.Property(e => e.NumerDomu).IsRequired();
                entity.Property(e => e.NumerLokalu).IsRequired();
                entity.Property(e => e.Poczta).IsRequired();
            });

            modelBuilder.Entity<DanePracownikaZatrudnienie>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.NumerKonta).IsRequired();
                entity.Property(e => e.Umowa).IsRequired();
                entity.Property(e => e.Etat).IsRequired();
                entity.Property(e => e.Bank).IsRequired();
                entity.Property(e => e.NFZ).IsRequired();
                entity.Property(e => e.UlgaPodatkowa).IsRequired();
                entity.Property(e => e.KosztUzyskaniaPrzychodu).IsRequired();
                entity.Property(e => e.Dzial).IsRequired();
                entity.Property(e => e.Stanowisko).IsRequired();
                entity.Property(e => e.StawkaGodzinowa).IsRequired();
                entity.HasOne(e => e.Podstawowe).WithMany(m => m.Zatrudnienie);
            });
        }
    }
}
