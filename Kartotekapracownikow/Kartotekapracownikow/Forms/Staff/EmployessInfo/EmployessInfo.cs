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
        private string imageEmployeesUpdateBase64;

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

                    DateTime dataPomoc = (DateTime)queryZatrudnienie.DataRozpoczeciaPracy;

                    IloscPrzepracowanychDni(dataPomoc);

                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas wyświetlania");
                }
            }
        }

        private void IloscPrzepracowanychDni(DateTime data)
        {
            DateTime now = DateTime.Now.Date;
            int different = DateTime.Compare(now, data.Date);

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
                using (var db = new Database())
                {
                    try
                    {
                        //Aktualizacja danych o zatrudnieniu
                        var update = (from s in db.DanePracownikaZatrudnienie where s.ID == danePracownikaID + 1 select s).First();
                        update.NumerKonta = numerKontaTB.Text;
                        update.Umowa = umowaTB.Text;
                        update.Etat = etatTB.Text;
                        update.Bank = bankTB.Text;
                        update.NFZ = nfzTB.Text;
                        update.UlgaPodatkowa = ulgapodatkowaTB.Text;
                        update.KosztUzyskaniaPrzychodu = kosztUzyskaniaPrzychoduTB.Text;
                        update.Dzial = dzialTB.Text;
                        update.Stanowisko = stanowiskoTB.Text;
                        update.StawkaGodzinowa = stawkaZaGodzine.Text;
                        //update.DataRozpoczeciaPracy = dataRozpoczęciaPracyTB.Text;
                        update.DziennyCzasPracy = dziennyCzasPracyTB.Text;
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


    }
}
