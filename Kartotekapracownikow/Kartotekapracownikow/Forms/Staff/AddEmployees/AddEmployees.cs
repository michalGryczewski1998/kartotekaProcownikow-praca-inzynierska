using System;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kartotekapracownikow.DatabaseModel;


namespace Kartotekapracownikow.Forms.AddEmployees
{
    public partial class AddEmployees : Form
    {

        private static AddEmployees _instance = null;

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
            InsertData();
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
            string scierzkaZdjeciePracownika;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {

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

        private static async Task InsertData()
        {

            var danePodstawowe = new DanePracownikaPodstawowe
            {
                Nazwisko = "Gryczewski",
                Imie = "Michał",
                ZdjeciePracownika = "photo.png",
                DataUrodzenia = DateTime.Now,
                NumerTelefonu = "605384407",
                AdresEmail = "michal@wp.pl",
                MiejsceUrodzenia = "Tczew",
                Plec = true,
                ImieMatki = "Izabela",
                ImieOjca = "Krzysztof",
                PESEL = "98050502018",
                NIP = "1323",
                Kraj = "Polska",
                Wojewodztwo = "Pomorskie",
                Gmina = "Subkowy",
                KodZamieszkania = "83-120",
                Miejscowosc = "Subkowy",
                Ulica = "Wybickiego",
                NumerDomu = "66",
                NumerLokalu = "",
                Poczta = "Subkowy",
            };

            var daneZatrudnienie = new DanePracownikaZatrudnienie
            {
                NumerKonta = 56489,
                Umowa = "O pracę",
                Etat = "Pełny",
                Bank = "PHO BP",
                NFZ = "Sokrates Subkowy",
                UlgaPodatkowa = "Nie",
                KosztUzyskaniaPrzychodu = "Tak",
                Dzial = "IT",
                Stanowisko = "Programista",
                StawkaGodzinowa = 24,
            };

            using (var db = new Database())
            {
                await db.DanePracownikaPodstawowe.AddAsync(danePodstawowe);
                await db.DanePracownikaZatrudnienie.AddAsync(daneZatrudnienie);
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
            DateTime dataUrodzinHelp = Convert.ToDateTime(dataUrodzinDTP.Text);

            if (dataUrodzinHelp >= DateTime.Today)
            {
                dataUrodzeniaEP.SetError(dataUrodzinDTP, "Niepoprawna data");
            }
        }

        private void peselTB_TextChanged(object sender, EventArgs e)
        {
            string peselPomoc = peselTB.Text;

            if(peselPomoc.Length == 11)
            {
                int[] peselWagi = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                int suma = 0;
                string liczbaKontrolnaSubstring = peselPomoc.Substring(10);
                int liczbaKontrolna = int.Parse(liczbaKontrolnaSubstring);

                for(int i = 0; i < peselWagi.Length; i++)
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
    }
}
