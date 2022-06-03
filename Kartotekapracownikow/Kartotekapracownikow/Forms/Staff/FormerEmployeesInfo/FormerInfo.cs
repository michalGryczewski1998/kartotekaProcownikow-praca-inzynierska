using Kartotekapracownikow.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.FormerEmployeesInfo
{
    public partial class FormerInfo : Form
    {
        int employeesID;

        public FormerInfo(int employesID)
        {
            InitializeComponent();
            this.employeesID = employesID;
            ZapytanieZwolnionyPracownik();
        }

        private void ZapytanieZwolnionyPracownik()
        {
            try
            {
                using (var db = new Database())
                {
                    var query = (from zwolnieni in db.ZwolnieniPracownicy
                                 where zwolnieni.ID == employeesID
                                 select new
                                 {
                                     zwolnieni.Imie,
                                     zwolnieni.Nazwisko,
                                     zwolnieni.Kraj,
                                     zwolnieni.NumerTelefonu,
                                     zwolnieni.Umowa,
                                     zwolnieni.Etat,
                                     zwolnieni.Dzial,
                                     zwolnieni.PrzyczynaZwolnienia,
                                     zwolnieni.OpisPrzyczynyZwolnienia,
                                     zwolnieni.Stanowisko,
                                     zwolnieni.StawkaGodzinowa,
                                     zwolnieni.DziennyCzasPracy,
                                     zwolnieni.IloscPrzepracowanychDni,
                                     zwolnieni.DataRozpoczeciaPracy,
                                     zwolnieni.DataZakonczeniaPracy
                                 }).Single();

                    ImiePracownikaTB.Text = query.Imie.ToString();
                    NazwiskoTB.Text = query.Nazwisko.ToString();
                    KrajTB.Text = query.Kraj.ToString();
                    NumerTelefonuTB.Text = query.NumerTelefonu.ToString();
                    UmowaTB.Text = query.Umowa.ToString();
                    EtatTB.Text = query.Etat.ToString();
                    DzialTB.Text = query.Dzial.ToString();
                    PrzyczynaZwolnieniaTB.Text = query.PrzyczynaZwolnienia.ToString();
                    OpisPrzyczynyZwolnieniaTB.Text = query.OpisPrzyczynyZwolnienia.ToString();
                    StanowiskoTB.Text = query.Stanowisko.ToString();
                    StawkaGodzinowaTB.Text = query.StawkaGodzinowa.ToString();
                    DziennyCzasPracyTB.Text = query.DziennyCzasPracy.ToString();
                    PoczatekPracyTB.Text = query.DataRozpoczeciaPracy.ToString();
                    KoniecPracyTB.Text = query.DataZakonczeniaPracy.ToString();
                    IloscPrzepracowanychDniTB.Text = query.IloscPrzepracowanychDni.ToString();
                }
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Błąd podczas pobierania danych");
            }

        }

        private void UmowaPodgladBTN_Click(object sender, EventArgs e)
        {
            // TODO: podgląd umowy PDF w WindowsForm
        }
    }
}
