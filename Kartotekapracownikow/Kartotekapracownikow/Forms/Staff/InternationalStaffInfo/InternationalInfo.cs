using Kartotekapracownikow.DatabaseModel;
using Kartotekapracownikow.Forms.Email;
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

namespace Kartotekapracownikow.Forms.Staff.InternationalStaffInfo
{
    public partial class InternationalInfo : Form
    {
        private int Id;
        private string wysylkaEmailDoPracownika;

        public InternationalInfo(int index)
        {
            this.Id = index;
            InitializeComponent();
            _ = DanePracownika();
        }

        private async Task DanePracownika()
        {
            try
            {
                using var db = new Database();

                var podstawoweZapytanie = (
                    from collection in db.DanePracownikZagranicznyPodstawowes
                    where collection.ID == Id + 1
                    select new
                    {
                        collection.Imie,
                        collection.Nazwisko,
                        collection.ImieMatki,
                        collection.Plec,
                        collection.ImieOjca,
                        collection.MiejsceUrodzenia,
                        collection.DataUrodzenia,
                        collection.KrajPochodzenia,
                        collection.Miejscowosc,
                        collection.Gmina,
                        collection.KodPocztowy,
                        collection.Poczta,
                        collection.Ulica,
                        collection.DomMieszkanie,
                        collection.Kraj,
                        collection.PodzialAdministracyjny,
                        collection.ZdjeciePracownika,
                        collection.TelefonKontaktowy,
                        collection.AdresEmail,
                        collection.OsobaZaufana,
                        collection.NumerTelefonuOsobyZaufanej
                    }).Single();

                var zatrudnienieZapytanie = (
                    from zatrudnienie in db.DanePracownikZagranicznyZatrudnienies
                    where zatrudnienie.ID == Id + 1
                    select new
                    {
                        zatrudnienie.SzkolaSrednia,
                        zatrudnienie.PoziomJezykaObcego,
                        zatrudnienie.Uczelnia,
                        zatrudnienie.SpecjalizacjaZawodowa,
                        zatrudnienie.Tytul,
                        zatrudnienie.Dzial,
                        zatrudnienie.Stanowisko,
                        zatrudnienie.StawkaGodzinowa,
                        zatrudnienie.DataZatrudnienia,
                        zatrudnienie.DziennyCzasPracy,
                        zatrudnienie.TypZezwolenia,
                        zatrudnienie.MiejsceWydaniaWizy,
                        zatrudnienie.NumerWizy,
                        zatrudnienie.NumerKontrolnyWizy,
                        zatrudnienie.NumerPaszportu,
                        zatrudnienie.Wpisy,
                        zatrudnienie.TypKlasaWizy,
                        zatrudnienie.WaznoscWizyStart,
                        zatrudnienie.WaznoscWizyKoniec,
                        zatrudnienie.SkanDokumentuPobytowego,
                        zatrudnienie.ZezwolenieNaPobytCzasowy,
                        zatrudnienie.TypUmowy,
                        zatrudnienie.Etat,
                        zatrudnienie.Bank,
                        zatrudnienie.NumerKonta,
                        zatrudnienie.UbezpieczenieZdrowotne,
                        zatrudnienie.UlgaPodatkowa,
                        zatrudnienie.KosztUzyskaniaPrzychodu
                    }).Single();

                imiePracownikaTB.Text = podstawoweZapytanie.Imie.ToString();
                nazwiskoPracownikaTB.Text = podstawoweZapytanie.Nazwisko.ToString();
                imieMatkiTB.Text = podstawoweZapytanie.ImieMatki.ToString();
                imieOjcaTB.Text = podstawoweZapytanie.ImieOjca.ToString();
                miejsceUrodzeniaTB.Text = podstawoweZapytanie.MiejsceUrodzenia.ToString();
                DataUrodzinDTP.Value = podstawoweZapytanie.DataUrodzenia;
                plecTB.Text = podstawoweZapytanie.Plec.ToString();
                KrajPochodzeniaTB.Text = podstawoweZapytanie.KrajPochodzenia.ToString();
                KrajZamieszkaniaTB.Text = podstawoweZapytanie.Kraj.ToString();
                miejscowoscTB.Text = podstawoweZapytanie.Miejscowosc.ToString();
                ulicaTB.Text = podstawoweZapytanie.Ulica.ToString();
                gminaTB.Text = podstawoweZapytanie.Gmina.ToString();
                kodTB.Text = podstawoweZapytanie.KodPocztowy.ToString();
                numerDomuLokaluTB.Text = podstawoweZapytanie.DomMieszkanie.ToString();
                pocztaTB.Text = podstawoweZapytanie.Poczta.ToString();
                PodzialAdministracyjnyTB.Text = podstawoweZapytanie.PodzialAdministracyjny.ToString();
                numertelefonuPracownikaTB.Text = podstawoweZapytanie.TelefonKontaktowy.ToString();
                adresEmailPracownikaTB.Text = podstawoweZapytanie.AdresEmail.ToString();
                wysylkaEmailDoPracownika = podstawoweZapytanie.AdresEmail.ToString();
                numerTelefonuNagleWypadkiTB.Text = podstawoweZapytanie.NumerTelefonuOsobyZaufanej.ToString();


                byte[] zdjecie = Convert.FromBase64String(podstawoweZapytanie.ZdjeciePracownika.ToString());
                var pomocZdjecie = new MemoryStream(zdjecie, 0, zdjecie.Length);
                zdjeciePracownikaPB.Image = Image.FromStream(pomocZdjecie, true);

                DzialTB.Text = zatrudnienieZapytanie.Dzial.ToString();
                StanowiskoTB.Text = zatrudnienieZapytanie.Stanowisko.ToString();
                StawkaGodzinowaTB.Text = zatrudnienieZapytanie.StawkaGodzinowa.ToString();
                DataPracaDTP.Value = zatrudnienieZapytanie.DataZatrudnienia;
                DziennyCzasPracyTB.Text = zatrudnienieZapytanie.DziennyCzasPracy.ToString();

                SzkolaSredniaTB.Text = zatrudnienieZapytanie.SzkolaSrednia.ToString();
                PoziomJezykaObcegoTB.Text = zatrudnienieZapytanie.PoziomJezykaObcego.ToString();
                UczelniaTB.Text = zatrudnienieZapytanie.Uczelnia.ToString();
                SpecjalizacjaTB.Text = zatrudnienieZapytanie.SpecjalizacjaZawodowa.ToString();
                TytulPoUkonczeniuUczelniTB.Text = zatrudnienieZapytanie.Tytul.ToString();

                TypZezwoleniaTB.Text = zatrudnienieZapytanie.TypZezwolenia.ToString();
                MiejsceWydaniaTB.Text = zatrudnienieZapytanie.MiejsceWydaniaWizy.ToString();
                NumerWizyTB.Text = zatrudnienieZapytanie.NumerWizy.ToString();
                NumerKontrolnyTB.Text = zatrudnienieZapytanie.NumerKontrolnyWizy.ToString();
                NumerPaszportuTB.Text = zatrudnienieZapytanie.NumerPaszportu.ToString();
                WpisyTB.Text = zatrudnienieZapytanie.Wpisy.ToString();
                TypKlasaWizyTB.Text = zatrudnienieZapytanie.TypKlasaWizy.ToString();
                StartWizaDTP.Value = zatrudnienieZapytanie.WaznoscWizyStart;
                KoniecWizaDTP.Value = zatrudnienieZapytanie.WaznoscWizyKoniec;
                DataWygasnieciaKartyPobytuTymczasowegoDTP.Value = zatrudnienieZapytanie.ZezwolenieNaPobytCzasowy;

                TypUmowyTB.Text = zatrudnienieZapytanie.TypUmowy.ToString();
                etatTB.Text = zatrudnienieZapytanie.Etat.ToString();
                bankTB.Text = zatrudnienieZapytanie.Bank.ToString();
                numerKontaTB.Text = zatrudnienieZapytanie.NumerKonta.ToString();
                UbezpieczenieZdrowotneTB.Text = zatrudnienieZapytanie.UbezpieczenieZdrowotne.ToString();
                ulgaPodatkowaTB.Text = zatrudnienieZapytanie.UlgaPodatkowa.ToString();
                kosztUzyskaniaPrzychoduTB.Text = zatrudnienieZapytanie.KosztUzyskaniaPrzychodu.ToString();

                IloscPrzepracowanychDni();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas pobierania danych.");
            }
            
        }

        private void IloscPrzepracowanychDni()
        {
            DateTime StartTime;

            using (var db = new Database())
            {
                var queryZatrudnienie = (from zatrudnienie in db.DanePracownikZagranicznyZatrudnienies
                                         where zatrudnienie.ID == Id + 1
                                         select new
                                         {
                                             zatrudnienie.DataZatrudnienia
                                         }).Single();

                StartTime = queryZatrudnienie.DataZatrudnienia;
            }

            DateTime EndTime = DateTime.Now.Date;
            double different = (EndTime - StartTime).Days;

            iloscPrzepracowanychDniTB.Text = different.ToString();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            panel.AutoScroll = true;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Visible = false;
            panel.HorizontalScroll.Maximum = 0;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void OdswierzBTN_Click(object sender, EventArgs e)
        {
            _ = DanePracownika();
        }

        private void EmailBTN_Click(object sender, EventArgs e)
        {
            EmailMessage email = new EmailMessage(wysylkaEmailDoPracownika);
            email.ShowDialog();
        }

        private void EdytujZatrudnienieBTN_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateZatrudnienie();
            }
            catch
            {
                MessageBox.Show("Nie można zaktualizować danych pracownika, proszę ponowic próbę");
            }
        }

        private void UpdateZatrudnienie()
        {
            string Dzial = DzialTB.Text;
            string Stanowisko = StanowiskoTB.Text;
            string StawkaGodzinowa = StawkaGodzinowaTB.Text;
            DateTime DataZatrudnienia = DataPracaDTP.Value;
            string DziennyCzasPracy = DziennyCzasPracyTB.Text;

            string SzkolaSrednia = SzkolaSredniaTB.Text;
            string PoziomJezykaObcego = PoziomJezykaObcegoTB.Text;
            string Uczelnia = UczelniaTB.Text;
            string SpecjalizacjaZawodowa = SpecjalizacjaTB.Text;
            string Tytul = TytulPoUkonczeniuUczelniTB.Text;

            string TypZezwolenia = TypZezwoleniaTB.Text;
            string MiejsceWydaniaWizy = MiejsceWydaniaTB.Text;
            double NumerWizy = Convert.ToDouble(NumerWizyTB.Text);
            string NumerKontrolnyWizy = NumerKontrolnyTB.Text;
            string NumerPaszportu = NumerPaszportuTB.Text;
            string Wpisy = WpisyTB.Text;
            string TypKlasaWizy = TypKlasaWizyTB.Text;
            DateTime WaznoscWizyStart = StartWizaDTP.Value;
            DateTime WaznoscWizyKoniec = KoniecWizaDTP.Value;
            DateTime ZezwolenieNaPobytCzasowy = DataWygasnieciaKartyPobytuTymczasowegoDTP.Value;

            string TypUmowy = TypUmowyTB.Text;
            string Etat = etatTB.Text;
            string Bank = bankTB.Text;
            string NumerKonta = numerKontaTB.Text;
            string UbezpieczenieZdrowotne = UbezpieczenieZdrowotneTB.Text;
            string UlgaPodatkowa = ulgaPodatkowaTB.Text;
            string KosztUzyskaniaPrzychodu = kosztUzyskaniaPrzychoduTB.Text;

            try
            {
                using (var db = new Database())
                {
                    var updateZatrudnienie = (from s in db.DanePracownikZagranicznyZatrudnienies where s.ID == Id + 1 select s).First();

                    updateZatrudnienie.Dzial = Dzial;
                    updateZatrudnienie.Stanowisko = Stanowisko;
                    updateZatrudnienie.StawkaGodzinowa = StawkaGodzinowa;
                    updateZatrudnienie.DataZatrudnienia = DataZatrudnienia;
                    updateZatrudnienie.DziennyCzasPracy = DziennyCzasPracy;
                    updateZatrudnienie.SzkolaSrednia = SzkolaSrednia;
                    updateZatrudnienie.PoziomJezykaObcego = PoziomJezykaObcego;
                    updateZatrudnienie.Uczelnia = Uczelnia;
                    updateZatrudnienie.SpecjalizacjaZawodowa = SpecjalizacjaZawodowa;
                    updateZatrudnienie.Tytul = Tytul;
                    updateZatrudnienie.TypZezwolenia = TypZezwolenia;
                    updateZatrudnienie.MiejsceWydaniaWizy = MiejsceWydaniaWizy;
                    updateZatrudnienie.NumerWizy = NumerWizy;
                    updateZatrudnienie.NumerKontrolnyWizy = NumerKontrolnyWizy;
                    updateZatrudnienie.NumerPaszportu = NumerPaszportu;
                    updateZatrudnienie.Wpisy = Wpisy;
                    updateZatrudnienie.TypKlasaWizy = TypKlasaWizy;
                    updateZatrudnienie.WaznoscWizyStart = WaznoscWizyStart;
                    updateZatrudnienie.WaznoscWizyKoniec = WaznoscWizyKoniec;
                    updateZatrudnienie.TypUmowy = TypUmowy;
                    updateZatrudnienie.Etat = Etat;
                    updateZatrudnienie.Bank = Bank;
                    updateZatrudnienie.NumerKonta = NumerKonta;
                    updateZatrudnienie.UbezpieczenieZdrowotne = UbezpieczenieZdrowotne;
                    updateZatrudnienie.UlgaPodatkowa = UlgaPodatkowa;
                    updateZatrudnienie.KosztUzyskaniaPrzychodu = KosztUzyskaniaPrzychodu;

                    db.SaveChanges();
                }
             
                MessageBox.Show("Zaktualizowano pomyślnie dane o zatrudnieniu.");
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas aktualizacji danych o zatrudnieniu.");
            }
        }

        private void EdytujPodstawoweBTN_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePodstawowe();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie można zaktualizować danych pracownika, proszę ponowic próbę.");
            }
        }

        private void UpdatePodstawowe()
        {
            string imiePracownika = imiePracownikaTB.Text;
            string nazwiskoPracownika = nazwiskoPracownikaTB.Text;
            string imieMatki = imieMatkiTB.Text;
            string imieOjca = imieOjcaTB.Text;
            string miejsceUrodzenia = miejsceUrodzeniaTB.Text;
            DateTime dataUrodzenia = DataUrodzinDTP.Value;
            string krajPochodzenia = KrajPochodzeniaTB.Text;
            string krajZamieszkania = KrajZamieszkaniaTB.Text;
            string miejscowosc = miejscowoscTB.Text;
            string ulica = ulicaTB.Text;
            string gmina = gminaTB.Text;
            string kod = kodTB.Text;
            string numerDomuLokalu = numerDomuLokaluTB.Text;
            string poczta = pocztaTB.Text;
            string podzialAdministracyjny = PodzialAdministracyjnyTB.Text;
            string telefonDoPracownika = numertelefonuPracownikaTB.Text;
            string adresEmail = adresEmailPracownikaTB.Text;
            string osobaZaufana = numerDoTB.Text;
            string numerTelefonuOsobaZaufana = numerTelefonuNagleWypadkiTB.Text;

            try
            {
                using(var db = new Database())
                {
                    var updatePodstawowe = (from p in db.DanePracownikZagranicznyPodstawowes where p.ID == Id + 1 select p).First();
                    updatePodstawowe.Imie = imiePracownika;
                    updatePodstawowe.Nazwisko = nazwiskoPracownika;
                    updatePodstawowe.ImieMatki = imieMatki;
                    updatePodstawowe.ImieOjca = imieOjca;
                    updatePodstawowe.MiejsceUrodzenia = miejsceUrodzenia;
                    updatePodstawowe.DataUrodzenia = dataUrodzenia;
                    updatePodstawowe.KrajPochodzenia = krajPochodzenia;
                    updatePodstawowe.Kraj = krajZamieszkania;
                    updatePodstawowe.Miejscowosc = miejscowosc;
                    updatePodstawowe.Ulica = ulica;
                    updatePodstawowe.Gmina = gmina;
                    updatePodstawowe.KodPocztowy = kod;
                    updatePodstawowe.DomMieszkanie = numerDomuLokalu;
                    updatePodstawowe.Poczta = poczta;
                    updatePodstawowe.PodzialAdministracyjny = podzialAdministracyjny;
                    updatePodstawowe.TelefonKontaktowy = telefonDoPracownika;
                    updatePodstawowe.OsobaZaufana = osobaZaufana;
                    updatePodstawowe.NumerTelefonuOsobyZaufanej = numerTelefonuOsobaZaufana;

                    db.SaveChanges();
                }
                MessageBox.Show("Zaktualizowano pomyślnie dane podstawowe.");
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas aktualizacji danych podstawowych.");
            }
        }
    }
}
