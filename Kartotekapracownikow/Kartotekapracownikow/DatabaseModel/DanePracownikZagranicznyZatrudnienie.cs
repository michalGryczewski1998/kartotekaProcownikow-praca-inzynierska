using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartotekapracownikow.DatabaseModel
{
    public class DanePracownikZagranicznyZatrudnienie
    {
        public int ID { get; set; }

        public string SzkolaSrednia
        {
            get;
            set;
        }

        public string PoziomJezykaObcego
        {
            get;
            set;
        }

        public string Uczelnia
        {
            get;
            set;
        }

        public string SpecjalizacjaZawodowa
        {
            get;
            set;
        }

        public string Tytul
        {
            get;
            set;
        }

        public string Dzial
        {
            get;
            set;
        }

        public string Stanowisko
        {
            get;
            set;
        }

        public string StawkaGodzinowa
        {
            get;
            set;
        }

        public DateTime DataZatrudnienia
        {
            get;
            set;
        }

        public string DziennyCzasPracy
        {
            get;
            set;
        }

        public string TypZezwolenia
        {
            get;
            set;
        }

        public string MiejsceWydaniaWizy
        {
            get;
            set;
        }

        public double NumerWizy
        {
            get;
            set;
        }

        public string NumerKontrolnyWizy
        {
            get;
            set;
        }

        public string NumerPaszportu
        {
            get;
            set;
        }

        public string Wpisy
        {
            get;
            set;
        }

        public string TypKlasaWizy
        {
            get;
            set;
        }

        public DateTime WaznoscWizyStart
        {
            get;
            set;
        }

        public DateTime WaznoscWizyKoniec
        {
            get;
            set;
        }

        public string SkanDokumentuPobytowego
        {
            get;
            set;
        }

        public DateTime? ZezwolenieNaPobytCzasowy
        {
            get;
            set;
        }
        public int PodstawoweId
        {
            get;
            set;
        }

        public virtual ICollection<DanePracownikZagranicznyPodstawowe> PodstawoweZagraniczny
        {
            get;
            private set;
        }
    }
}
