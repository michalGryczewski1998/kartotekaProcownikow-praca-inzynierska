using System.Windows;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
// add a reference to System.ComponentModel.DataAnnotations DLL

namespace Kartotekapracownikow.DatabaseModel
{
    public class Database : DbContext
    {
        public DbSet<DanePracownikaPodstawowe> DanePracownikaPodstawowe { get; set; }
        public DbSet<DanePracownikaZatrudnienie> DanePracownikaZatrudnienie { get; set; }
        public DbSet<ZwolnieniPracownicy> ZwolnieniPracownicy { get; set; }
        public DbSet<DanePracownikZagranicznyPodstawowe> DanePracownikZagranicznyPodstawowes { get; set; }
        public DbSet<DanePracownikZagranicznyZatrudnienie> DanePracownikZagranicznyZatrudnienies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder _optionsBuilder)
        {
            try
            {
                _optionsBuilder.UseMySQL($"server=localhost;Port=3306;database=kartoteka-pracownicza;user=root;password=SonyW990");               
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
                entity.Property(e => e.DoKogoWNaglymWypadku).IsRequired();
                entity.Property(e => e.NumerNagleWypadki).IsRequired();
            });

            modelBuilder.Entity<DanePracownikaZatrudnienie>(entity =>
            {
                entity.HasKey(d => d.ID);
                entity.Property(d => d.NumerKonta).IsRequired();
                entity.Property(d => d.Umowa).IsRequired();
                entity.Property(d => d.Etat).IsRequired();
                entity.Property(d => d.Bank).IsRequired();
                entity.Property(d => d.NFZ).IsRequired();
                entity.Property(d => d.UlgaPodatkowa).IsRequired();
                entity.Property(d => d.KosztUzyskaniaPrzychodu).IsRequired();
                entity.Property(d => d.Dzial).IsRequired();
                entity.Property(d => d.Stanowisko).IsRequired();
                entity.Property(d => d.StawkaGodzinowa).IsRequired();
                entity.Property(d => d.DataRozpoczeciaPracy).IsRequired();
                entity.Property(d => d.DziennyCzasPracy).IsRequired();
                entity.HasOne(d => d.Podstawowe).WithMany(m => m.Zatrudnienie);
            });

            modelBuilder.Entity<ZwolnieniPracownicy>(entity =>
            {
                entity.HasKey(z => z.ID);
                entity.Property(z => z.Imie).IsRequired();
                entity.Property(z => z.Nazwisko).IsRequired();
                entity.Property(z => z.Kraj).IsRequired();
                entity.Property(z => z.NumerTelefonu);
                entity.Property(z => z.Umowa).IsRequired();
                entity.Property(z => z.Etat).IsRequired();
                entity.Property(z => z.Dzial).IsRequired();
                entity.Property(z => z.PrzyczynaZwolnienia).IsRequired();
                entity.Property(z => z.OpisPrzyczynyZwolnienia).IsRequired();
                entity.Property(z => z.Stanowisko).IsRequired();
                entity.Property(z => z.StawkaGodzinowa).IsRequired();
                entity.Property(z => z.DataRozpoczeciaPracy).IsRequired();
                entity.Property(z => z.DataZakonczeniaPracy).IsRequired();
                entity.Property(z => z.DziennyCzasPracy).IsRequired();
                entity.Property(z => z.IloscPrzepracowanychDni).IsRequired();
            });

        }
    }
}
