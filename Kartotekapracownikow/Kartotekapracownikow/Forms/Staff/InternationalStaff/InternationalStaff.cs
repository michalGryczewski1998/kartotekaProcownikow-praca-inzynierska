using Kartotekapracownikow.Forms.Staff.InternationalStaff;
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

namespace Kartotekapracownikow.Forms.InternationalStaff
{
    public partial class InternationalStaff : Form
    {
        private static InternationalStaff _instance = null;
        private string ZdjeciePracownikaBase64;
        public static InternationalStaff Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new InternationalStaff();
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

        private InternationalStaff()
        {
            InitializeComponent();
        }

        private void InternationalStaff_Load(object sender, EventArgs e)
        {

        }
        private void DodajZdjecieBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|" + "All files (*.*)|*.*";

            try
            {
                string fileName = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    ZdjeciePracownikaZagranicznegoPB.Image = Image.FromFile(openFileDialog.FileName);
                }

                byte[] imageArray = System.IO.File.ReadAllBytes(fileName);
                ZdjeciePracownikaBase64 = Convert.ToBase64String(imageArray);
                //Debug.WriteLine(base64ConvertImageEmployee);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas dodawania zdjęcia");
            }
        }
        private void DodajBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DaneZatrudnienie zatrudnienie = new(new DataParameters
                {
                    Imie = ImieTB.Text,
                    Nazwisko = NazwiskoTB.Text,
                    Plec = PlecCB.SelectedItem.ToString(),
                    ImieMatki = ImieMatkiTB.Text,
                    ImieOjca = ImieOjcaTB.Text,
                    MiejsceUrodzenia = MiejsceUrodzeniaTB.Text,
                    DataUrodzenia = DataUrodzeniaDTP.Value,
                    KrajPochodzenia = KrajPochodzeniaTB.Text,
                    Miejscowosc = miejscowoscTB.Text,
                    Gmina = gminaTB.Text,
                    Kod = kodTB.Text,
                    Poczta = PocztaTB.Text,
                    Ulica = UlicaTB.Text,
                    NumerDomuMieszkania = numerDomuTB.Text,
                    KrajZamieszkania = krajTB.Text,
                    PodzialAdministracyjnyKraju = PodzialAdmKrajuTB.Text,
                    ZdjeciePracownika = ZdjeciePracownikaBase64,
                    SzkolaSrednia = SzkolaSredniaTB.Text,
                    PoziomJezykaObcego = PoziomJezykaObcegoTB.Text,
                    Uczelnia = UczelniaTB.Text,
                    Specjalizacja = SpecjalizacjaTB.Text,
                    Tytul = TytulPoUkonczeniuUczelniTB.Text,
                    TelefonKontaktowy = NumerTelefonuPracownikaTB.Text,
                    AdresEmail = AdresEmailPracownika.Text,
                    OsobaZaufanaPracownika = OsobaZaufanaPracownikaTB.Text,
                    NumerTelefonuOsobyZaufanej = NumerTelefonuOsobyZaufanejTB.Text,
                    Dzial = dzial.Text,
                    Stanowisko = stanowiskoCB.SelectedItem.ToString(),
                    StawkaGodzinowa = stawkaGodzinaTB.Text,
                    DataZatrudnienia = DataZatrudnieniaDTP.Value,
                    DziennyCzasPracy = dziennyCzasPracyCB.SelectedItem.ToString(),
                    Bank = bankTB.Text,
                    NumerKonta = numerKontaTB.Text,
                    UbezpieczenieNFZ = UbezpieczenieCB.SelectedItem.ToString(),
                    TypUmowy = Umowa.Text,
                    Etat = daneEtatCB.SelectedItem.ToString(),
                    UlgaPodatkowa = UlgaPodatkowaLB.SelectedItem.ToString(),
                    KosztUzyskaniaPrzychodu = KosztPrzychoduLB.SelectedItem.ToString(),
                });

                zatrudnienie.ShowDialog();
            }
            catch (NullReferenceException d)
            {
                MessageBox.Show($"Proszę wpisać wszystkie dane. {d.Message}");
            }
        }
    }
}
