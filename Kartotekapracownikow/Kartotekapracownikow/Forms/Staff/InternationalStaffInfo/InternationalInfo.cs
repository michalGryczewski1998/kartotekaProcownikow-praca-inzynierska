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

namespace Kartotekapracownikow.Forms.Staff.InternationalStaffInfo
{
    public partial class InternationalInfo : Form
    {
        private int Id;

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
                        collection.ZdjeciePracownika
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
                        zatrudnienie.ZezwolenieNaPobytCzasowy
                    }).Single();

                imiePracownikaTB.Text = podstawoweZapytanie.Imie.ToString();
                nazwiskoPracownikaTB.Text = podstawoweZapytanie.Nazwisko.ToString();
                imieMatkiTB.Text = podstawoweZapytanie.ImieMatki.ToString();
                imieOjcaTB.Text = podstawoweZapytanie.ImieOjca.ToString();
                miejsceUrodzeniaTB.Text = podstawoweZapytanie.MiejsceUrodzenia.ToString();
                DataUrodzinDTP.Value = podstawoweZapytanie.DataUrodzenia;
                //plecTB.Text = podstawoweZapytanie.Plec.ToString();
                KrajPochodzeniaTB.Text = podstawoweZapytanie.KrajPochodzenia.ToString();
                KrajZamieszkaniaTB.Text = podstawoweZapytanie.Kraj.ToString();
                miejscowoscTB.Text = podstawoweZapytanie.Miejscowosc.ToString();
                ulicaTB.Text = podstawoweZapytanie.Ulica.ToString();
                gminaTB.Text = podstawoweZapytanie.Gmina.ToString();
                kodTB.Text = podstawoweZapytanie.KodPocztowy.ToString();
                numerDomuLokaluTB.Text = podstawoweZapytanie.DomMieszkanie.ToString();
                pocztaTB.Text = podstawoweZapytanie.Poczta.ToString();
                PodzialAdministracyjnyTB.Text = podstawoweZapytanie.PodzialAdministracyjny.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas pobierania danych.");
            }
            
        }

    }
}
