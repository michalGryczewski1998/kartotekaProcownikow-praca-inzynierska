using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartotekapracownikow.DatabaseModel
{
    class FormerEmployees : EntityModel
    {

        public string Nazwisko { get; set; }

        public string Imie { get; set; }

        public DateTime? DataUrodzenia { get; set; }

        public string NumerTelefonu { get; set; }

        public string MiejsceUrodzenia { get; set; }

        public bool Plec { get; set; }

        public string ImieMatki { get; set; }

        public string ImieOjca { get; set; }

        public string PESEL { get; set; }

        public int NIP { get; set; }

        public string Kraj { get; set; }

        public string Wojewodztwo { get; set; }

        public string Gmina { get; set; }

        public string KodZamieszkania { get; set; }

        public string Miejscowosc { get; set; }

        public string Ulica { get; set; }

        public string NumerDomu { get; set; }

        public string NumerLokalu { get; set; }

        public string Poczta { get; set; }

        public bool Rezydent { get; set; }

        public string RodzajNumeruIdentyfikacyjnego { get; set; }

        public string KrajWydaniaNumeruIdentyfikacyjnego { get; set; }

        public string NumerIdentyfikacyjny { get; set; }

        public string Stanowisko { get; set; }

        public string Dział { get; set; }

        public double StawkaGodzinowa { get; set; }
    }
}
