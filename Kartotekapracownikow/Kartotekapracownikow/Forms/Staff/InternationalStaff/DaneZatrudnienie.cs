using Kartotekapracownikow.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.InternationalStaff
{
    public partial class DaneZatrudnienie : Form
    {
        private string PdfToBase64;

        private string Imie;
        private string Nazwisko;
        private string ImieMatki;
        private string ImieOjca;
        private string MiejsceUrodzenia;
        private DateTime DataUrodzenia;
        private string KrajPochodzenia;
        private string Miejscowosc;
        private string Gmina;
        private string Kod;
        private string Poczta;
        private string Ulica;
        private string NumerDomuMieszkania;
        private string KrajZamieszkania;
        private string PodzialAdministracyjnyKraju;
        private string ZdjeciePracownika;
        private string SzkolaSrednia;
        private string PoziomJezykaObcego;
        private string Uczelnia;
        private string Specjalizacja;
        private string Tytul;
        private string TelefonKontaktowy;
        private string AdresEmail;
        private string OsobaZaufanaPracownika;
        private string NumerTelefonuOsobyZaufanej;
        private string Dzial;
        private string Stanowisko;
        private string StawkaGodzinowa;
        private DateTime DataZatrudnienia;
        private string DziennyCzasPracy;

        public DaneZatrudnienie(DataParameters parameters)
        {
            InitializeComponent();

            Imie = parameters.Imie;
            Nazwisko = parameters.Nazwisko;
            ImieMatki = parameters.ImieMatki;
            ImieOjca = parameters.ImieOjca;
            MiejsceUrodzenia = parameters.MiejsceUrodzenia;
            DataUrodzenia = parameters.DataUrodzenia;
            KrajPochodzenia = parameters.KrajPochodzenia;
            Miejscowosc = parameters.Miejscowosc;
            Gmina = parameters.Gmina;
            Kod = parameters.Kod;
            Poczta = parameters.Poczta;
            Ulica = parameters.Ulica;
            NumerDomuMieszkania = parameters.NumerDomuMieszkania;
            KrajPochodzenia = parameters.KrajPochodzenia;
            PodzialAdministracyjnyKraju = parameters.PodzialAdministracyjnyKraju;
            ZdjeciePracownika = parameters.ZdjeciePracownika;
            SzkolaSrednia = parameters.SzkolaSrednia;
            PoziomJezykaObcego = parameters.PoziomJezykaObcego;
            Uczelnia = parameters.Uczelnia;
            Specjalizacja = parameters.Specjalizacja;
            Tytul = parameters.Tytul;
            TelefonKontaktowy = parameters.TelefonKontaktowy;
            AdresEmail = parameters.AdresEmail;
            OsobaZaufanaPracownika = parameters.OsobaZaufanaPracownika;
            NumerTelefonuOsobyZaufanej = parameters.NumerTelefonuOsobyZaufanej;
            Dzial = parameters.Dzial;
            Stanowisko = parameters.Stanowisko;
            StawkaGodzinowa = parameters.StawkaGodzinowa;
            DataZatrudnienia = parameters.DataZatrudnienia;
            DziennyCzasPracy = parameters.DziennyCzasPracy;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typWybrany = TypZezwoleniaCB.SelectedIndex;

            switch (typWybrany)
            {
                case 0:
                    TypZezwoleniaInformacjaTB.Text = $"Wniosek o zezwolenie na pracę TYP A składasz kiedy Twój pracownik będzie wykonywał pracę w Polsce, " +
                        $"a Ty prowadzisz działalność na terytorium RP.";
                    break;
                case 1:
                    TypZezwoleniaInformacjaTB.Text = $"Wniosek o zezwolenie na pracę TYP B składasz kiedy Cudzoziemiec pełni funkcję w zarządzie " +
                        $"osoby prawnej wpisanej do rejestru przedsiębiorców lub będącej spółką kapitałową w organizacji albo prowadzi sprawy spółki komandytowej " +
                        $"lub komandytowo-akcyjnej jako komplementariusz, albo w związku z udzieleniem mu prokury przez okres przekraczający łącznie 6 miesięcy w ciągu kolejnych 12 miesięcy.";
                    break;
                case 3:
                    TypZezwoleniaInformacjaTB.Text = $"Zezwolenie to jest wydawane gdy pracownik, wykonuje pracę u pracodawcy zagranicznego i jest delegowany na terytorium " +
                        $"Rzeczypospolitej Polskiej na okres przekraczający 30 dni w roku kalendarzowym do oddziału lub zakładu " +
                        $"podmiotu zagranicznego albo podmiotu powiązanego, w rozumieniu ustawy z dnia 26 lipca 1991 r. o podatku dochodowym od osób fizycznych, z pracodawcą zagranicznym.";
                    break;
                case 4:
                    TypZezwoleniaInformacjaTB.Text = $"Zezwolenie na pracę typ jest wymagane jeśli Cudzoziemiec, wykonuje pracę u pracodawcy zagranicznego nieposiadającego oddziału, zakładu " +
                        $"lub innej formy zorganizowanej działalności na terytorium Rzeczypospolitej Polskiej i jest delegowany na terytorium Rzeczypospolitej Polskiej w celu realizacji " +
                        $"usługi o charakterze tymczasowym i okazjonalnym (usługa eksportowa).";
                    break;
                case 5:
                    TypZezwoleniaInformacjaTB.Text = $"Zezwolenie na pracę typ E jest wymagane jeśli Cudzoziemiec wykonuje pracę u pracodawcy zagranicznego i jest delegowany na terytorium " +
                        $"Rzeczypospolitej Polskiej na okres przekraczający 30 dni w ciągu kolejnych 6 miesięcy w innym celu niż wskazany w zezwoleniach typu B, C, D.";
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "PDF Files|*.pdf";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileArray = System.IO.File.ReadAllBytes(open.FileName);
                    PdfToBase64 = Convert.ToBase64String(fileArray);
                }

                Debug.WriteLine(PdfToBase64);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas dodawania dokumentu.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PobytCzasowyCB.Checked)
            {
                DataWygasnieciaKartyPobytuTymczasowegoDTP.Enabled = true;
            }
            else
            {
                DataWygasnieciaKartyPobytuTymczasowegoDTP.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = DodajDoBazy();
        }

        private async Task DodajDoBazy()
        {
            using(var db = new Database())
            {

            }
        }
    }
}
