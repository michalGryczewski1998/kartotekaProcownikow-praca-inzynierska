using Kartotekapracownikow.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.EmployessInfo
{
    public partial class EmployessInfo : Form
    {
        private int danePracownikaID;

        public EmployessInfo(int danePracownikaID)
        {
            this.danePracownikaID = danePracownikaID;
            InitializeComponent();
            _ = DanePracownika(danePracownikaID);
        }

        private async Task DanePracownika(int danePracownikaID)
        {
            using (var db = new Database())
            {
                try
                {
                    var query = (from collection in db.DanePracownikaPodstawowe
                                  where collection.ID == danePracownikaID + 1
                                  select new
                                  {
                                      collection.Imie,
                                      collection.Nazwisko,
                                      collection.ZdjeciePracownika,
                                      collection.DataUrodzenia,
                                      collection.NumerTelefonu,
                                      collection.AdresEmail,
                                      collection.MiejsceUrodzenia,
                                      collection.Plec,
                                      collection.ImieMatki,
                                      collection.ImieOjca,
                                      collection.PESEL,
                                      collection.NIP,
                                      collection.Kraj,
                                      collection.Wojewodztwo,
                                      collection.Gmina,
                                      collection.KodZamieszkania,
                                      collection.Miejscowosc,
                                      collection.Ulica,
                                      collection.NumerDomu,
                                      collection.NumerLokalu,
                                      collection.Poczta
                                  }).Single();

                    var queryZatrudnienie = (from zatrudnienie in db.DanePracownikaZatrudnienie
                                 where zatrudnienie.ID == danePracownikaID + 1
                                 select new
                                 {
                                     zatrudnienie.NumerKonta,
                                     zatrudnienie.Umowa,
                                     zatrudnienie.Etat,
                                     zatrudnienie.Bank,
                                     zatrudnienie.NFZ,
                                     zatrudnienie.UlgaPodatkowa,
                                     zatrudnienie.KosztUzyskaniaPrzychodu,
                                     zatrudnienie.Dzial,
                                     zatrudnienie.Stanowisko,
                                     zatrudnienie.StawkaGodzinowa
                                 }).Single();

                    byte[] zdjecie = Convert.FromBase64String(query.ZdjeciePracownika.ToString());
                    var pomocZdjecie = new MemoryStream(zdjecie,0,zdjecie.Length);

                    zdjeciePracownikaPB.Image = Image.FromStream(pomocZdjecie, true);
                    imiePracownikaTB.Text = query.Imie.ToString();
                    nazwiskoPracownikaTB.Text = query.Nazwisko.ToString();
                    dataUrodzeniaTB.Text = query.DataUrodzenia.ToString();
                    numertelefonuPracownika.Text = query.NumerTelefonu.ToString();
                    adresEmailPracownika.Text = query.AdresEmail.ToString();
                    miejsceUrodzeniaTB.Text = query.MiejsceUrodzenia.ToString();
                    plecTB.Text = query.Plec.ToString();
                    imieMatkiTB.Text = query.ImieMatki.ToString();
                    imieOjcaTB.Text = query.ImieOjca.ToString();
                    peselTB.Text = query.PESEL.ToString();
                    nipTB.Text = query.NIP.ToString();
                    krajTB.Text = query.Kraj.ToString();
                    wojewodztwoTB.Text = query.Wojewodztwo.ToString();
                    gminaTB.Text = query.Gmina.ToString();
                    kodTB.Text = query.KodZamieszkania.ToString();
                    miejscowoscTB.Text = query.Miejscowosc.ToString();
                    ulicaTB.Text = query.Ulica.ToString();
                    numerDomuTB.Text = query.NumerDomu.ToString();
                    numerLokaluTB.Text = query.NumerLokalu.ToString();
                    pocztaTB.Text = query.Poczta.ToString();

                    numerKontaTB.Text = queryZatrudnienie.NumerKonta.ToString();
                    umowaTB.Text = queryZatrudnienie.Umowa.ToString();
                    etatTB.Text = queryZatrudnienie.Etat.ToString();
                    bankTB.Text = queryZatrudnienie.Bank.ToString();
                    nfzTB.Text = queryZatrudnienie.NFZ.ToString();
                    ulgapodatkowaTB.Text = queryZatrudnienie.UlgaPodatkowa.ToString();
                    kosztUzyskaniaPrzychoduTB.Text = queryZatrudnienie.KosztUzyskaniaPrzychodu.ToString();
                    dzialTB.Text = queryZatrudnienie.Dzial.ToString();
                    stanowiskoTB.Text = queryZatrudnienie.Stanowisko.ToString();
                    stawkaGodzinaTB.Text = queryZatrudnienie.StawkaGodzinowa.ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas wyświetlania");
                }
            }
        }

        private void EmployessInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
