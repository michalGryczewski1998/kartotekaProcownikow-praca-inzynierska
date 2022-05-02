using Kartotekapracownikow.DatabaseModel;
using System.Data.SqlClient;
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
        private string newPicture;

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
                                      collection.Poczta,
                                      collection.DoKogoWNaglymWypadku,
                                      collection.NumerNagleWypadki
                                      
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
                                     zatrudnienie.StawkaGodzinowa,
                                     zatrudnienie.DataRozpoczeciaPracy,
                                     zatrudnienie.DziennyCzasPracy
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
                    numerDo.Text = query.DoKogoWNaglymWypadku.ToString();
                    numerTelefonuNagleWypadki.Text = query.NumerNagleWypadki.ToString();

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
                    dataRozpoczęciaPracyTB.Text = queryZatrudnienie.DataRozpoczeciaPracy.ToString();
                    dziennyCzasPracyTB.Text = queryZatrudnienie.DziennyCzasPracy.ToString();

                    IloscPrzepracowanychDni();

                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas wyświetlania");
                }
            }
        }

        private void IloscPrzepracowanychDni()
        {
            /*
             * Metoda oblicza ile upłynęło dni 
             * między datą zatrudnienia a dniem dzisiejszym.
             * 
             */

            DateTime StartTime;

            using (var db = new Database())
            {
                var queryZatrudnienie = (from zatrudnienie in db.DanePracownikaZatrudnienie
                                         where zatrudnienie.ID == danePracownikaID + 1
                                         select new
                                         {
                                             zatrudnienie.DataRozpoczeciaPracy
                                         }).Single();

                StartTime = queryZatrudnienie.DataRozpoczeciaPracy;
            }

            DateTime EndTime = DateTime.Now.Date;
            double different = (EndTime - StartTime).Days;

            iloscPrzepracowanychDniTB.Text = different.ToString();
        }
        private void EmployessInfo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void iloscPrzepracowanychDniTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zdjeciePracownikaPB.Image.Dispose();
            zdjeciePracownikaPB.Image = null;
            string imageEmployeesUpdateBase64;

        OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|" + "All files (*.*)|*.*";

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    newPicture = openFileDialog.FileName;
                    zdjeciePracownikaPB.Image = Image.FromFile(openFileDialog.FileName);
                }

                byte[] imageArray = File.ReadAllBytes(newPicture);
                imageEmployeesUpdateBase64 = Convert.ToBase64String(imageArray);
                //Debug.WriteLine(base64ConvertImageEmployee);

                try
                {
                    using (var db = new Database())
                    {
                        var uploadPicture = (from s in db.DanePracownikaPodstawowe where s.ID == danePracownikaID + 1 select s).First();
                        System.Diagnostics.Debug.WriteLine(imageEmployeesUpdateBase64);
                        uploadPicture.ZdjeciePracownika = imageEmployeesUpdateBase64;
                        MessageBox.Show("Zaktualizowano pomyślnie :)");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas aktualizacji !");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas dodawania zdjęcia");
            }
        }

        private void edytujZatrudnienieBTN_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            try
            {
                string numerKonta = numerKontaTB.Text;
                string umowa = umowaTB.Text;
                string etat = etatTB.Text;
                string bank = bankTB.Text;
                string nfz = nfzTB.Text;
                string ulgaPodatkowa = ulgapodatkowaTB.Text;
                string kosztUzyskPrzy = kosztUzyskaniaPrzychoduTB.Text;
                string dzial = dzialTB.Text;
                string stanowisko = stanowiskoTB.Text;
                string stawkaGodz = stawkaGodzinaTB.Text;
                string dziennyCzasPracy = dziennyCzasPracyTB.Text;

                using (var db = new Database())
                {
                    try
                    {
                        //Aktualizacja danych o zatrudnieniu
                        var update = (from s in db.DanePracownikaZatrudnienie where s.ID == danePracownikaID + 1 select s).First();
                        update.NumerKonta = numerKonta;
                        update.Umowa = umowa;
                        update.Etat = etat;
                        update.Bank = bank;
                        update.NFZ = nfz;
                        update.UlgaPodatkowa = ulgaPodatkowa;
                        update.KosztUzyskaniaPrzychodu = kosztUzyskPrzy;
                        update.Dzial = dzial;
                        update.Stanowisko = stanowisko;
                        update.StawkaGodzinowa = stawkaGodz;
                        //update.DataRozpoczeciaPracy = dataRozpoczęciaPracyTB.Text;
                        update.DziennyCzasPracy = dziennyCzasPracy;
                        //Zapisanie zaktualizowanych danych
                        db.SaveChanges();
                        MessageBox.Show("Zaktualizowano pomyślnie :)");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Błąd podczas aktualizacji !");
                    }                   
                }
            }
            catch (Exception)
            {
                UpdateError.SetError(edytujZatrudnienieBTN, "Błąd podczas aktualizacji.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDataPodstawowedane();
        }

        private void UpdateDataPodstawowedane()
        {
            try
            {
                using (var db = new Database())
                {
                    string imie = imiePracownikaTB.Text;
                    string nazwisko = nazwiskoPracownikaTB.Text;
                    //DateTime DataUrodzenia,
                    string NumerTelefonu = numertelefonuPracownika.Text;
                    string AdresEmail = adresEmailPracownika.Text;
                    string MiejsceUrodzenia = miejsceUrodzeniaTB.Text;
                    string Plec = plecTB.Text;
                    string ImieMatki = imieMatkiTB.Text;
                    string ImieOjca = imieOjcaTB.Text;
                    string PESEL = peselTB.Text;
                    string NIP = nipTB.Text;
                    string Kraj = krajTB.Text;
                    string Wojewodztwo = wojewodztwoTB.Text;
                    string Gmina = gminaTB.Text;
                    string KodZamieszkania = kodTB.Text;
                    string Miejscowosc = miejscowoscTB.Text;
                    string Ulica = ulicaTB.Text;
                    string NumerDomu = numerDomuTB.Text;
                    string NumerLokalu = numerLokaluTB.Text;
                    string Poczta = pocztaTB.Text;
                    string DoKogoWNaglymWypadku = numerDo.Text;
                    string NumerNagleWypadki = numerTelefonuNagleWypadki.Text;

                    try
                    {
                        var update = (from s in db.DanePracownikaPodstawowe where s.ID == danePracownikaID + 1 select s).First();
                        update.Nazwisko = nazwisko;
                        update.Imie = imie;
                        //update.DataUrodzenia = DataUrodzenia,
                        update.NumerTelefonu = NumerTelefonu;
                        update.AdresEmail = AdresEmail;
                        update.MiejsceUrodzenia = MiejsceUrodzenia;
                        update.Plec = Plec;
                        update.ImieMatki = ImieMatki;
                        update.ImieOjca = ImieOjca;
                        update.PESEL = PESEL;
                        update.NIP = NIP;
                        update.Kraj = Kraj;
                        update.Wojewodztwo = Wojewodztwo;
                        update.Gmina = Gmina;
                        update.KodZamieszkania = KodZamieszkania;
                        update.Miejscowosc = Miejscowosc;
                        update.Ulica = Ulica;
                        update.NumerDomu = NumerDomu;
                        update.NumerLokalu = NumerLokalu;
                        update.Poczta = Poczta;
                        update.DoKogoWNaglymWypadku = DoKogoWNaglymWypadku;
                        update.NumerNagleWypadki = NumerNagleWypadki;

                        db.SaveChanges();

                        MessageBox.Show("Zaktualizowano pomyślnie :)");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Błąd podczas aktualizacji !");
                    }
                }
            }

            catch (Exception)
            {
                UpdateErrorPodstawoweEP.SetError(EdytujPodstawoweBTN, "Błąd podczas aktualizacji.");
            }
           
        }
    }
}

