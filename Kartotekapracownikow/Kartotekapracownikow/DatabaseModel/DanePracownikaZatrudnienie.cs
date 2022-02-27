using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartotekapracownikow.DatabaseModel
{
    class DanePracownikaZatrudnienie
    {
        public int ID { get; set; }

        public double NumerKonta { get; set; }

        public string Umowa { get; set; }

        public string Etat { get; set; }

        public string Bank { get; set; }

        public string NFZ { get; set; }

        public string UlgaPodatkowa { get; set; }

        public string KosztUzyskaniaPrzychodu { get; set; }

        public string Dzial { get; set; }

        public string Stanowisko { get; set; }

        public int StawkaGodzinowa { get; set; }

    }
}
