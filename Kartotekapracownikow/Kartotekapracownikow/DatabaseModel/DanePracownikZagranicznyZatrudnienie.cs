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
