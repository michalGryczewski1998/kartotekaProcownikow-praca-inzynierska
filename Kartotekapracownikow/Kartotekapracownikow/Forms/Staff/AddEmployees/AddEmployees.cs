using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kartotekapracownikow.DatabaseModel;
using Microsoft.Data.SqlClient;

namespace Kartotekapracownikow.Forms.AddEmployees
{
    public partial class AddEmployees : Form
    {

        private static AddEmployees _instance = null;
        string scierzkaZdjeciePracownika;
        static string base64ConvertImageEmployee = "";

        public static AddEmployees Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddEmployees();
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

        private AddEmployees()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dodanie scrollBar do panelu
            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
        }

        private void dodajPracownikaBTN_Click(object sender, EventArgs e)
        {
            string imie = imiePracownikaTB.Text;
            string nazwisko = nazwiskoPracownikaTB.Text;
            string ZdjeciePracownika = base64ConvertImageEmployee;
            DateTime DataUrodzenia = dataUrodzinDTP.Value;
            string NumerTelefonu = numertelefonuPracownika.Text;
            string AdresEmail = adresEmailPracownika.Text;
            string MiejsceUrodzenia = miejsceUrodzeniaTB.Text;
            string Plec = plecCB.SelectedItem.ToString();
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

            double NumerKonta = Convert.ToDouble(numerKontaTB.Text);
            string Umowa = daneUmowaLB.SelectedItems.ToString();
            string Etat = daneEtatLB.SelectedItems.ToString();
            string Bank = bankTB.Text;
            string NFZ = nfzTB.Text;
            string UlgaPodatkowa = ulgaPodatkowaCB.SelectedItem.ToString();
            string KosztUzyskaniaPrzychodu = kosztyUzyskaniaPrzychoduCB.SelectedItem.ToString();
            string Dzial = dzial.Text;
            string Stanowisko = stanowiskoCB.SelectedItem.ToString();
            int StawkaGodzinowa = Convert.ToInt32(stawkaGodzinaTB.Text);

        _ = InsertData(
                imie,
                nazwisko,
                ZdjeciePracownika,
                DataUrodzenia,
                NumerTelefonu,
                AdresEmail,
                MiejsceUrodzenia,
                Plec,
                ImieMatki,
                ImieOjca,
                PESEL,
                NIP,
                Kraj,
                Wojewodztwo,
                Gmina,
                KodZamieszkania,
                Miejscowosc,
                Ulica,
                NumerDomu,
                NumerLokalu,
                Poczta,
                NumerKonta,
                Umowa,
                Etat,
                Bank,
                NFZ,
                UlgaPodatkowa,
                KosztUzyskaniaPrzychodu,
                Dzial,
                Stanowisko,
                StawkaGodzinowa
                );
        }

        private void anulujBTN_Click(object sender, EventArgs e)
        {

        }

        private void imiePracownikaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void nazwiskoPracownikaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void peselTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataUrodzinDTP_ValueChanged(object sender, EventArgs e)
        {
            dataUrodzinDTP.Format = DateTimePickerFormat.Short;
        }

        private void zdjecieBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter ="Images (*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|" +"All files (*.*)|*.*";

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    scierzkaZdjeciePracownika = openFileDialog.FileName;
                    zdjeciePracownikaPB.Image = Image.FromFile(openFileDialog.FileName);
                }

                byte[] imageArray = System.IO.File.ReadAllBytes(scierzkaZdjeciePracownika);
                base64ConvertImageEmployee = Convert.ToBase64String(imageArray);
                //Debug.WriteLine(base64ConvertImageEmployee);
            }
            catch(Exception)
            {
                MessageBox.Show("Błąd podczas dodawania zdjęcia");
            }

        }

        private void peselTB_Validated(object sender, EventArgs e)
        {
            string peselHelp = peselTB.Text;

            if (string.IsNullOrWhiteSpace(peselHelp))
            {
                walidacjaPeselEP.SetError(peselTB, "Podaj prawidłową wartość PESEL");
            }
            else
            {
                walidacjaPeselEP.Clear();
            }
        }

        private static async Task InsertData(

                string imie,
                string nazwisko,
                string ZdjeciePracownika,
                DateTime DataUrodzenia,
                string NumerTelefonu,
                string AdresEmail,
                string MiejsceUrodzenia,
                string Plec,
                string ImieMatki,
                string ImieOjca,
                string PESEL,
                string NIP,
                string Kraj,
                string Wojewodztwo,
                string Gmina,
                string KodZamieszkania,
                string Miejscowosc,
                string Ulica,
                string NumerDomu,
                string NumerLokalu,
                string Poczta,
                double NumerKonta,
                string Umowa,
                string Etat,
                string Bank,
                string NFZ,
                string UlgaPodatkowa,
                string KosztUzyskaniaPrzychodu,
                string Dzial,
                string Stanowisko,
                int StawkaGodzinowa

            )
        {         
            using (var db = new Database())
            {
                db.Database.EnsureCreated();

                try
                {
                    var danePodstawowe = new DanePracownikaPodstawowe
                    {
                        Nazwisko = nazwisko,
                        Imie = imie,
                        ZdjeciePracownika = ZdjeciePracownika,
                        DataUrodzenia = DataUrodzenia,
                        NumerTelefonu = NumerTelefonu,
                        AdresEmail = AdresEmail,
                        MiejsceUrodzenia = MiejsceUrodzenia,
                        Plec = Plec,
                        ImieMatki = ImieMatki,
                        ImieOjca = ImieOjca,
                        PESEL = PESEL,
                        NIP = NIP,
                        Kraj = Kraj,
                        Wojewodztwo = Wojewodztwo,
                        Gmina = Gmina,
                        KodZamieszkania = KodZamieszkania,
                        Miejscowosc = Miejscowosc,
                        Ulica = Ulica,
                        NumerDomu = NumerDomu,
                        NumerLokalu = NumerLokalu,
                        Poczta = Poczta,
                    };

                    await db.DanePracownikaPodstawowe.AddAsync(danePodstawowe);

                    var daneZatrudnienie = new DanePracownikaZatrudnienie
                    {
                        NumerKonta = NumerKonta,
                        Umowa = Umowa,
                        Etat = Etat,
                        Bank = Bank,
                        NFZ = NFZ,
                        UlgaPodatkowa = UlgaPodatkowa,
                        KosztUzyskaniaPrzychodu = KosztUzyskaniaPrzychodu,
                        Dzial = Dzial,
                        Stanowisko = Stanowisko,
                        StawkaGodzinowa = StawkaGodzinowa,
                    };

                    await db.DanePracownikaZatrudnienie.AddAsync(daneZatrudnienie);
                    await db.SaveChangesAsync();
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas dodawania pracownika do bazy danych !! \n");
                }         
            }
        }

        private void nipTB_Validated(object sender, EventArgs e)
        {
            /*
             * Funkcja sprawdza poprawnosc NIP-u
             * Mnoży każdą liczbę przez wagę
             * Następnie sprawdza czy ta suma jest równa liczbie kontrolnej
             * Jeśli tak to NIP jest poprawny, w przeciwnym wypadku NIP jest nieprawidłowy
             */
            string nip = nipTB.Text;
            //System.Diagnostics.Debug.WriteLine(nip);

            if(nip.Length != 10)
            {
                walidajcaNipEP.SetError(nipTB, "Numer NIP składa się z 11 cyfr");
            }
            else
            {
                int[] wagi = new int[] { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
                int suma = 0;

                string kontrolnaLiczbaSubstring = nip.Substring(9);
                int kontrolnaLiczba = int.Parse(kontrolnaLiczbaSubstring);

                for (int i = 0; i < wagi.Length; i++)
                {
                    suma += (int.Parse(nip.Substring(i, 1)) * wagi[i]);
                }

                if (suma % 11 != kontrolnaLiczba)
                {
                    walidajcaNipEP.SetError(nipTB, "Nieprawidłowy numer NIP");
                }
                else
                {
                    walidajcaNipEP.Clear();
                }
            }
        }

        private void nazwiskoPracownikaTB_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nazwiskoPracownikaTB.Text))
            {
                walidacjaNazwiskoEP.SetError(nazwiskoPracownikaTB, "Pole Nazwisko nie może być puste.");
            }
            else
            {
                walidacjaNazwiskoEP.Clear();
            }
        }

        private void imiePracownikaTB_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imiePracownikaTB.Text))
            {
                walidacjaImieEP.SetError(imiePracownikaTB, "Pole Imię nie może być puste.");
            }
            else
            {
                walidacjaImieEP.Clear();
            }
        }

        private void dataUrodzinDTP_Validated(object sender, EventArgs e)
        {
            DateTime dataUrodzinHelp = Convert.ToDateTime(dataUrodzinDTP.Value);

            if (dataUrodzinHelp >= DateTime.Today)
            {
                dataUrodzeniaEP.SetError(dataUrodzinDTP, "Niepoprawna data");
            }
        }

        private void peselTB_TextChanged(object sender, EventArgs e)
        {
            string peselPomoc = peselTB.Text;

            try
            {
                if (peselPomoc.Length == 11)
                {
                    int[] peselWagi = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                    int suma = 0;
                    string liczbaKontrolnaSubstring = peselPomoc.Substring(10);
                    int liczbaKontrolna = int.Parse(liczbaKontrolnaSubstring);

                    for (int i = 0; i < peselWagi.Length; i++)
                    {
                        suma += (int.Parse(peselPomoc.Substring(i, i + 1)) * peselWagi[i]);
                    }

                    suma = suma % 10;

                    if ((10 - suma) != liczbaKontrolna)
                    {
                        peselEP.SetError(peselTB, "Błędny PESEL");
                    }
                }
                else
                {
                    peselEP.SetError(peselTB, "PESEL zbyt krótki");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Błędny pesel");
            }
            
        }
    }
}
