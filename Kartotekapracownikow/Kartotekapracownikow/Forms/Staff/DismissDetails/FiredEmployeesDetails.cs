using Kartotekapracownikow.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.DismissDetails
{
    public partial class FiredEmployeesDetails : Form
    {
        int employeesID;

        string imiePracownika;
        string nazwiskoPracownika;
        string kraj;
        string numerTelefonu;
        string umowa;
        string etat;
        string dzial;
        string stanowisko;
        string stawkaGodzinowa;
        string dziennyCzasPracy;
        DateTime dataRozpoczeciaPracy;
        DateTime dataZakonczeniaPracy;

        public FiredEmployeesDetails(int employeesID)
        {
            InitializeComponent();
            this.employeesID = employeesID;
            WczytajDane();
        }

        private void WczytajDane()
        {
            try
            {
                using (var db = new Database())
                {
                    try
                    {
                        var query = (from podstawowe in db.DanePracownikaPodstawowe
                                     join zatrudnienie in db.DanePracownikaZatrudnienie
                                     on podstawowe.ID equals zatrudnienie.ID
                                     select new
                                     {
                                         podstawowe.Imie,
                                         podstawowe.Nazwisko,
                                         podstawowe.Kraj,
                                         podstawowe.NumerTelefonu,
                                         zatrudnienie.Umowa,
                                         zatrudnienie.Etat,
                                         zatrudnienie.Dzial,
                                         zatrudnienie.Stanowisko,
                                         zatrudnienie.StawkaGodzinowa,
                                         zatrudnienie.DataRozpoczeciaPracy,
                                         zatrudnienie.DziennyCzasPracy,
                                     }).Single();

                        imiePracownika = query.Imie.ToString();
                        nazwiskoPracownika = query.Nazwisko.ToString();
                        kraj = query.Kraj.ToString();
                        numerTelefonu = query.NumerTelefonu.ToString();
                        umowa = query.Umowa.ToString();
                        etat = query.Etat.ToString();
                        dzial = query.Dzial.ToString();
                        stanowisko = query.Stanowisko.ToString();
                        stawkaGodzinowa = query.StawkaGodzinowa.ToString();
                        dziennyCzasPracy = query.DziennyCzasPracy.ToString();
                        dataRozpoczeciaPracy = query.DataRozpoczeciaPracy;

                        ImieZwalnianegoPracownikaTB.Text = imiePracownika;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Błąd");
                        ZwolnijPracownikaGB();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Błąd połączenia z bazą danych.");
            }
        }

        private void ZwolnijPracownikaBTN_Click(object sender, EventArgs e)
        {
            ZwolnijPracownikaGB();
        }

        private void ZwolnijPracownikaGB()
        {
            try
            {
                using(var db = new Database())
                {
                    double iloscPrzepracowanych = ObliczenieIlosciPrzepracowanychDni();

                    try
                    {
                        db.Database.EnsureCreated();

                        var ZwolnieniPracownicy = new ZwolnieniPracownicy
                        {
                            Imie = imiePracownika,
                            Nazwisko = nazwiskoPracownika,
                            Kraj = kraj,
                            NumerTelefonu = numerTelefonu,
                            Umowa = umowa,
                            Etat = etat,
                            Dzial = dzial,
                            PrzyczynaZwolnienia = PrzyczynaZwolnieniaTB.ToString(),
                            OpisPrzyczynyZwolnienia = OpisZwolnieniaTB.ToString(),
                            Stanowisko = stanowisko,
                            StawkaGodzinowa = stawkaGodzinowa,
                            DataRozpoczeciaPracy = dataRozpoczeciaPracy,
                            DataZakonczeniaPracy = dataZakonczeniaPracy,
                            DziennyCzasPracy = dziennyCzasPracy,
                            IloscPrzepracowanychDni = iloscPrzepracowanych

                        };

                        db.ZwolnieniPracownicy.Add(ZwolnieniPracownicy);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Błąd podczas zwalniania pracownika \n");
                    }

                    try
                    {
                        var zatrudnienie = (from z in db.DanePracownikaZatrudnienie where z.ID == employeesID select z).FirstOrDefault();
                        db.DanePracownikaZatrudnienie.Remove(zatrudnienie);

                        var podstawowe = (from p in db.DanePracownikaPodstawowe where p.ID == employeesID select p).FirstOrDefault();
                        db.DanePracownikaPodstawowe.Remove(podstawowe);

                        db.SaveChanges();

                        MessageBox.Show("Pracownik " + imiePracownika + " został zwolniony.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Pracownik " + imiePracownika + " nie został zwolniony.");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Błąd podczas zwalniania");
            }
        }

        private double ObliczenieIlosciPrzepracowanychDni()
        {
            DateTime StartTime;

            using (var db = new Database())
            {
                var queryZatrudnienie = (from zatrudnienie in db.DanePracownikaZatrudnienie
                                         where zatrudnienie.ID == employeesID
                                         select new
                                         {
                                             zatrudnienie.DataRozpoczeciaPracy
                                         }).Single();

                StartTime = queryZatrudnienie.DataRozpoczeciaPracy;
            }

            DateTime EndTime = DateTime.Now.Date;
            double different = (EndTime - StartTime).Days;

            return different;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Wyczysc
            Czyszczenie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Anuluj
            Czyszczenie();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Odswiez
            WczytajDane();
        }
        private void Czyszczenie()
        {
            PrzyczynaZwolnieniaTB.Clear();
            PrzyczynaZwolnieniaTB.Text = "";

            OpisZwolnieniaTB.Clear();
            OpisZwolnieniaTB.Text = "";
        }

        private void PrzyczynaZwolnieniaTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PrzyczynaZwolnieniaTB.Text))
            {
                e.Cancel = true;
                PrzyczynaZwolnieniaTB.Focus();
                PrzyczynaZwolnieniaEP.SetError(PrzyczynaZwolnieniaTB, "Proszę wpisać przyczynę zwolnienia pracownika");
            }
            else
            {
                e.Cancel = false;
                PrzyczynaZwolnieniaEP.SetError(PrzyczynaZwolnieniaTB, null);
            }
        }

        private void OpisZwolnieniaTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OpisZwolnieniaTB.Text))
            {
                e.Cancel = true;
                PrzyczynaZwolnieniaTB.Focus();
                OpisZwolnieniaEP.SetError(OpisZwolnieniaTB, "Proszę opisać przyczynę/ny zwolnienia");
            }
            else
            {
                e.Cancel = false;
                OpisZwolnieniaEP.SetError(OpisZwolnieniaTB, null);
            }
        }
    }
}
