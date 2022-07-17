using Kartotekapracownikow.DatabaseModel;
using Kartotekapracownikow.Forms.Staff.DismissDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.DismissEmployee
{
    public partial class DismissEmployee : Form
    {
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

        string imieZwolnionego;


        private static DismissEmployee _instance = null;
        int employeesID;
        public static DismissEmployee Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DismissEmployee();
                }
                return _instance;
            }
        }

        public static bool truOrFalseInstance
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private DismissEmployee()
        {
            InitializeComponent();
            WczytanieDanych();
        }

        private void WczytanieDanych()
        {
            using var db = new Database();
            try
            {
                var querry = (from collection in db.DanePracownikaPodstawowe
                              select new
                              {
                                  collection.ID,
                                  collection.Imie,
                                  collection.Nazwisko,
                                  collection.ImieMatki,
                                  collection.ImieOjca,
                                  collection.NumerTelefonu,
                                  collection.DataUrodzenia,
                                  collection.Miejscowosc,
                                  collection.Kraj
                              }).ToList();

                daneDGW.DataSource = querry;
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas wyświetlania");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {


            using var db = new Database();
            try
            {
                var querry = (from collection in db.DanePracownikZagranicznyPodstawowes
                              select new
                              {
                                  collection.ID,
                                  collection.Imie,
                                  collection.Nazwisko,
                                  collection.ImieMatki,
                                  collection.ImieOjca,
                                  collection.TelefonKontaktowy,
                                  collection.DataUrodzenia,
                                  collection.Miejscowosc,
                                  collection.Kraj
                              }).ToList();

                daneDGW.DataSource = querry;
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas wyświetlania");
            }
        }

        private void DaneDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Po kliknięciu w dany wiersz
             * zostanie przypisany do zmiennej 
             * jego ID, dzięki temu możemy 
             * wykonywac operacje.
             * 
             */
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = daneDGW.Rows[e.RowIndex];
                employeesID = (int)row.Cells["ID"].Value;
                imieZwolnionego = row.Cells["Imie"].Value.ToString();
                zaznaczonyPracownikLabel.Text = row.Cells["Imie"].Value.ToString();

                bool status;

                if (row.Cells["Kraj"].Value.ToString() == "Polska")
                {
                    status = true;
                    FiredEmployeesDetails fed = new FiredEmployeesDetails(employeesID, status);
                    fed.ShowDialog();
                }
                else
                {
                    status = false;
                    FiredEmployeesDetails fed = new FiredEmployeesDetails(employeesID, status);
                    fed.ShowDialog();
                }
            }
        }

        private void DismissEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ZwolnijPracownikaGB();

        }

        private void ZwolnijPracownikaGB()
        {
            /* Zwolnienie pracownika działa na zasadzie
             * usunięcia większości danych, ale zostana
             * tylko te dane, ktore potwierdza
             * ze dana osoba tu pracowala     .
             * 
             * Wiec usuwanie polega na usunieciu czesci danych,
             * jak i przeniesieniu pewnej puli informacji
             * do innej tabeli ZwolnieniPracownicy
             */

            dataZakonczeniaPracy = DateTime.Now.Date;

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
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd");
                    ZwolnijPracownikaGB();
                }

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

                    MessageBox.Show("Pracownik " + imieZwolnionego + " został zwolniony.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Pracownik " + imieZwolnionego + " nie został zwolniony.");
                }
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
            daneDGW.Update();
            daneDGW.Refresh();

            WczytanieDanych();
        }
    }
}
