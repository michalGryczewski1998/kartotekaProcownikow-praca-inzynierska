using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartotekapracownikow.DatabaseModel
{
    public class DanePracownikaZatrudnienie
    {
        public int ID { get; set; }

        public string NumerKonta { get; set; }

        public string Umowa { get; set; }

        public string Etat { get; set; }

        public string Bank { get; set; }

        public string NFZ { get; set; }

        public string UlgaPodatkowa { get; set; }

        public string KosztUzyskaniaPrzychodu { get; set; }

        public string Dzial { get; set; }

        public string Stanowisko { get; set; }

        public string StawkaGodzinowa { get; set; }

        public DateTime? DataRozpoczeciaPracy { get; set; } 

        public string DziennyCzasPracy { get; set; }

        public virtual DanePracownikaPodstawowe Podstawowe { get; set; }
    }
}
