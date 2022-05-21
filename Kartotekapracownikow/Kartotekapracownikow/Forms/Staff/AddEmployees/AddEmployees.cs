﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
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
        bool peselError;

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
            try
            {
                string Plec = plecCB.SelectedItem.ToString();
                string UlgaPodatkowa = ulgaPodatkowaCB.SelectedItem.ToString();
                string KosztUzyskaniaPrzychodu = kosztyUzyskaniaPrzychoduCB.SelectedItem.ToString();
                string Stanowisko = stanowiskoCB.SelectedItem.ToString();
                string PESEL = peselTB.Text;
                string DziennyCzasPracy = dziennyCzasPracyCB.SelectedItem.ToString();
                string Umowa = daneUmowaCB.SelectedItem.ToString();
                string Etat = daneEtatCB.SelectedItem.ToString();
                string imie = imiePracownikaTB.Text;
                string nazwisko = Nazwisko.Text;
                string ZdjeciePracownika = base64ConvertImageEmployee;
                DateTime DataUrodzenia = dataUrodzinDTP.Value;
                string NumerTelefonu = numertelefonuPracownikaTB.Text;
                string AdresEmail = adresEmailPracownika.Text;
                string MiejsceUrodzenia = miejsceUrodzeniaTB.Text;
                string ImieMatki = imieMatkiTB.Text;
                string ImieOjca = imieOjcaTB.Text;
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
                string DoKogoWNaglymWypadku = doKogoNaglyWypadekTB.Text;
                string NumerNagleWypadki = NumerTelefonuNaglyWypadekTB.Text;
                string NumerKonta = numerKontaTB.Text;
                string Bank = bankTB.Text;
                string NFZ = nfzTB.Text;
                string Dzial = dzial.Text;
                string StawkaGodzinowa = stawkaGodzinaTB.Text;
                DateTime DataRozpoczeciaPracy = dataZatrudnieniaDTP.Value;

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
                     DoKogoWNaglymWypadku,
                     NumerNagleWypadki,
                     NumerKonta,
                     Umowa,
                     Etat,
                     Bank,
                     NFZ,
                     UlgaPodatkowa,
                     KosztUzyskaniaPrzychodu,
                     Dzial,
                     Stanowisko,
                     StawkaGodzinowa,
                     DataRozpoczeciaPracy,
                     DziennyCzasPracy
                    );
            }
            catch (Exception)
            {
                MessageBox.Show("Proszę ponowić próbę.");
            }
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

        private void dataUrodzinDTP_ValueChanged(object sender, EventArgs e)
        {
            dataUrodzinDTP.Format = DateTimePickerFormat.Short;
        }
        private void zdjecieBTN_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|" + "All files (*.*)|*.*";

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
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas dodawania zdjęcia");
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
                string DoKogoWNaglymWypadku,
                string NumerNagleWypadki,
                string NumerKonta,
                string Umowa,
                string Etat,
                string Bank,
                string NFZ,
                string UlgaPodatkowa,
                string KosztUzyskaniaPrzychodu,
                string Dzial,
                string Stanowisko,
                string StawkaGodzinowa,
                DateTime DataRozpoczeciaPracy,
                string DziennyCzasPracy

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
                        DoKogoWNaglymWypadku = DoKogoWNaglymWypadku,
                        NumerNagleWypadki = NumerNagleWypadki
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
                        DataRozpoczeciaPracy = DataRozpoczeciaPracy,
                        DziennyCzasPracy = DziennyCzasPracy
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

        private void imiePracownikaTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imiePracownikaTB.Text))
            {
                e.Cancel = true;
                imiePracownikaTB.Focus();
                imieEP.SetError(imiePracownikaTB, "Proszę wprowadzić imie pracownika");
            }
            else
            {
                e.Cancel = false;
                imieEP.SetError(imiePracownikaTB, null);
            }
        }

        private void imiePracownikaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ustawiamy że w TextBox są dostępne tylko litery z zakresy a-zA-Z
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Nazwisko_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nazwisko.Text))
            {
                e.Cancel = true;
                imiePracownikaTB.Focus();
                walidacjaNazwiskoEP.SetError(Nazwisko, "Proszę wprowadzić nazwisko pracownika");
            }
            else
            {
                e.Cancel = false;
                walidacjaNazwiskoEP.SetError(Nazwisko, null);
            }
        }

        private void Nazwisko_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void miejsceUrodzeniaTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(miejsceUrodzeniaTB.Text))
            {
                e.Cancel = true;
                imiePracownikaTB.Focus();
                MiejsceUrodzeniaEP.SetError(miejsceUrodzeniaTB, "Proszę wprowadzić miejsce urodzenie");
            }
            else
            {
                e.Cancel = false;
                MiejsceUrodzeniaEP.SetError(miejsceUrodzeniaTB, null);
            }
        }

        private void miejsceUrodzeniaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void plecCB_Validating(object sender, CancelEventArgs e)
        {
            // plecCB.SelectedIndex == -1 znaczy że nie wybrano NIC 
            if (plecCB.SelectedIndex == -1)
            {
                e.Cancel = true;
                plecCB.Focus();
                PlecEP.SetError(plecCB, "Musisz wybrać jedną z opcji");
            }
            else
            {
                e.Cancel = false;
                PlecEP.SetError(plecCB, null);
            }
        }

        private void imieMatkiTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imieMatkiTB.Text))
            {
                e.Cancel = true;
                imieMatkiTB.Focus();
                ImieMatkiEP.SetError(imieMatkiTB, "Proszę wprowadzić imię matki");
            }
            else
            {
                e.Cancel = false;
                ImieMatkiEP.SetError(imieMatkiTB, null);
            }
        }

        private void imieMatkiTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void imieOjcaTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imieOjcaTB.Text))
            {
                e.Cancel = true;
                imieOjcaTB.Focus();
                ImieOjcaEP.SetError(imieOjcaTB, "Proszę wprowadzić imię ojca");
            }
            else
            {
                e.Cancel = false;
                ImieOjcaEP.SetError(imieOjcaTB, null);
            }
        }

        private void imieOjcaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void peselTB_Validating(object sender, CancelEventArgs e)
        {
            // TODO: Poprawic walidacje PESEL - DONE!
            string peselPomoc = peselTB.Text;
            int[] peselWagi = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            bool poprawnosc;
            e.Cancel = false;

            try
            {
                if (peselPomoc.Length == 11)
                {
                    int controlSum = ObliczSumeKontrolna(peselPomoc, peselWagi);
                    int controlNum = controlSum % 10;
                    controlNum = 10 - controlNum;
                    if (controlNum == 10)
                    {
                        controlNum = 0;
                    }
                    int lastDigit = int.Parse(peselPomoc[peselPomoc.Length - 1].ToString());
                    poprawnosc = controlNum == lastDigit;

                    if (poprawnosc == false)
                    {
                        e.Cancel = true;
                        peselTB.Focus();
                        peselEP.SetError(peselTB, "PESEL jest błędny");
                    }
                    else
                    {
                        e.Cancel = false;
                        peselEP.SetError(peselTB, null);
                    }
                }
                else
                {
                    e.Cancel = true;
                    peselTB.Focus();
                    peselEP.SetError(peselTB, "PESEL zbyt krótki");
                }
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                MessageBox.Show($"Błędny numer PESEL: {argumentOutOfRangeException.Message}");
            }
        }
        private void peselTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void nipTB_Validating(object sender, CancelEventArgs e)
        {
            string nipPomoc = nipTB.Text;

            int[] weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
            bool poprawnosc = false;

            try
            {
                if(nipPomoc.Length == 10)
                {
                    int controlSum = ObliczSumeKontrolna(nipPomoc, weights);
                    int controlNum = controlSum % 11;
                    if (controlNum == 10)
                    {
                        
                    }
                    int lastDigit = Convert.ToInt32(nipPomoc[nipPomoc.Length - 1].ToString());
                    poprawnosc = controlNum == lastDigit;

                    if (poprawnosc == false)
                    {
                        e.Cancel = true;
                        peselTB.Focus();
                        walidajcaNipEP.SetError(nipTB, "NIP jest błędny");
                    }
                    else
                    {
                        e.Cancel = false;
                        walidajcaNipEP.SetError(nipTB, null);
                    }
                }
                else
                {
                    e.Cancel = true;
                    nipTB.Focus();
                    walidajcaNipEP.SetError(nipTB, "NIP zbyt krótki");
                }
            }
            catch(ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                MessageBox.Show($"Błędny numer NIP: {argumentOutOfRangeException.Message}");
            }

        }
        private void nipTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private static int ObliczSumeKontrolna(string pesel, int[] wagi, int offset = 0)
        {
            int suma = 0;
            for (int i = 0; i < pesel.Length - 1; i++)
            {
                suma += wagi[i + offset] * int.Parse(pesel[i].ToString());
            }
            return suma;
        }

        private void dataUrodzinDTP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dataUrodzinDTP.Value.ToString()))
            {
                e.Cancel = true;
                plecCB.Focus();
                dataUrodzeniaEP.SetError(dataUrodzinDTP, "Proszę wprowadzić datę urodzin");
            }
            else
            {
                e.Cancel = false;
                dataUrodzeniaEP.SetError(dataUrodzinDTP, null);
            }
        }

        private void zdjeciePracownikaPB_Validating(object sender, CancelEventArgs e)
        {
            if(zdjeciePracownikaPB.Image == null)
            {
                e.Cancel = true;
                zdjeciePracownikaPB.Focus();
                zdjeciePracownikaEP.SetError(zdjeciePracownikaPB, "Proszę o wybranie zdjęcia");
            }
            else
            {
                e.Cancel = false;
                zdjeciePracownikaEP.SetError(zdjeciePracownikaPB, null);
            }
        }

        private void krajTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(krajTB.Text))
            {
                e.Cancel = true;
                krajTB.Focus();
                krajEP.SetError(krajTB, "Proszę wpisać nazwę kraju pochodzenia");
            }
            else
            {
                e.Cancel = false;
                krajEP.SetError(krajTB, null);
            }
        }

        private void krajTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void wojewodztwoTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(wojewodztwoTB.Text))
            {
                e.Cancel = true;
                wojewodztwoTB.Focus();
                wojewodztwoEP.SetError(wojewodztwoTB, "Proszę wpisać nazwę województwa");
            }
            else
            {
                e.Cancel = false;
                wojewodztwoEP.SetError(wojewodztwoTB, null);
            }
        }

        private void wojewodztwoTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gminaTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gminaTB.Text))
            {
                e.Cancel = true;
                gminaTB.Focus();
                gminaEP.SetError(gminaTB, "Proszę wpisać nazwę gminy");
            }
            else
            {
                e.Cancel = false;
                gminaEP.SetError(gminaTB, null);
            }
        }

        private void gminaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kodTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kodTB.Text))
            {
                e.Cancel = true;
                kodTB.Focus();
                kodPocztowyEP.SetError(kodTB, "Proszę wpisać kod pocztowy");
            }
            else
            {
                string pomocKodPocztowy = kodTB.Text;

                if (pomocKodPocztowy.Contains("-")){
                    e.Cancel = false;
                    kodPocztowyEP.SetError(kodTB, null);
                }
                else
                {
                    e.Cancel = true;
                    kodTB.Focus();
                    kodPocztowyEP.SetError(kodTB, "Kod pocztowy jest niepoprawny");
                }
            }
        }

        private void kodTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Zezwalamy tylko na liczby oraz znaki specjalne
            if (char.IsLetterOrDigit(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void miejscowoscTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(miejscowoscTB.Text))
            {
                e.Cancel = true;
                miejscowoscTB.Focus();
                miejscowoscEP.SetError(miejscowoscTB, "Proszę wpisać nazwę miejscowości");
            }
            else
            {
                e.Cancel = false;
                miejscowoscEP.SetError(miejscowoscTB, null);
            }
        }

        private void miejscowoscTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ulicaTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ulicaTB.Text))
            {
                e.Cancel = true;
                ulicaTB.Focus();
                ulicaEP.SetError(ulicaTB, "Proszę wpisać ulicę");
            }
            else
            {
                e.Cancel = false;
                ulicaEP.SetError(ulicaTB, null);
            }
        }

        private void ulicaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void numerDomuTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numerLokaluTB.Text))
            {
                if (string.IsNullOrWhiteSpace(numerDomuTB.Text))
                {
                    e.Cancel = true;
                    numerDomuTB.Focus();
                    numerDomuEP.SetError(numerDomuTB, "Proszę wpisać numer domu lub mieszkania");
                }
                else
                {
                    e.Cancel = false;
                    numerDomuEP.SetError(numerDomuTB, null);
                }
            }
        }

        private void numerLokaluTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numerDomuTB.Text))
            {
                if (string.IsNullOrWhiteSpace(numerLokaluTB.Text))
                {
                    e.Cancel = true;
                    numerLokaluTB.Focus();
                    numerLokaluEP.SetError(numerLokaluTB, "Proszę wpisać numer domu lub mieszkania");
                }
                else
                {
                    e.Cancel = false;
                    numerLokaluEP.SetError(numerLokaluTB, null);
                }
            }
        }

        private void pocztaTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pocztaTB.Text))
            {
                e.Cancel = true;
                pocztaTB.Focus();
                pocztaEP.SetError(pocztaTB, "Proszę wpisać ulicę");
            }
            else
            {
                e.Cancel = false;
                pocztaEP.SetError(pocztaTB, null);
            }
        }

        private void pocztaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void numertelefonuPracownika_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numertelefonuPracownikaTB.Text))
            {
                e.Cancel = true;
                numertelefonuPracownikaTB.Focus();
                numertelefonuEP.SetError(numertelefonuPracownikaTB, "Proszę wpisać numer telefonu");
            }
            else
            {
                string number = numertelefonuPracownikaTB.Text;
                const string motifPhoneNumberNormal = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
                const string motifPhoneNumber = @"^([\+]?[1-9]{2}[-]?|[0])?[1-9][0-9]{8}$";

                if (Regex.IsMatch(number, motifPhoneNumberNormal) || Regex.IsMatch(number, motifPhoneNumber))
                {
                    e.Cancel = false;
                    numertelefonuEP.SetError(numertelefonuPracownikaTB, null);
                }
                else
                {
                    e.Cancel = true;
                    numertelefonuPracownikaTB.Focus();
                    numertelefonuEP.SetError(numertelefonuPracownikaTB, "Numer telefonu błędny");
                }
            }
        }

        private void NumerTelefonuNaglyWypadekTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NumerTelefonuNaglyWypadekTB.Text))
            {
                e.Cancel = true;
                NumerTelefonuNaglyWypadekTB.Focus();
                NumertelefonuNaglyWypadekEP.SetError(NumerTelefonuNaglyWypadekTB, "Proszę wpisać numer telefonu");
            }
            else
            {
                string number = NumerTelefonuNaglyWypadekTB.Text;
                const string motifPhoneNumberNormal = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
                const string motifPhoneNumber = @"^([\+]?[1-9]{2}[-]?|[0])?[1-9][0-9]{8}$";

                if (Regex.IsMatch(number, motifPhoneNumberNormal) || Regex.IsMatch(number, motifPhoneNumber))
                {
                    e.Cancel = false;
                    NumertelefonuNaglyWypadekEP.SetError(NumerTelefonuNaglyWypadekTB, null);
                }
                else
                {
                    e.Cancel = true;
                    NumerTelefonuNaglyWypadekTB.Focus();
                    NumertelefonuNaglyWypadekEP.SetError(NumerTelefonuNaglyWypadekTB, "Numer telefonu błędny");
                }
            }
        }
    }
}
