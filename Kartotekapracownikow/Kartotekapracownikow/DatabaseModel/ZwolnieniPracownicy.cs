using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartotekapracownikow.DatabaseModel
{
    public class ZwolnieniPracownicy
    {

        public int ID { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string Kraj { get; set; }

        public string NumerTelefonu { get; set; }

        public string Umowa { get; set; }

        public string Etat { get; set; }

        public string Dzial { get; set; }

        public string PrzyczynaZwolnienia { get; set; }

        public string OpisPrzyczynyZwolnienia { get; set; }

        public string Stanowisko { get; set; }

        public string StawkaGodzinowa { get; set; }

        public DateTime DataRozpoczeciaPracy { get; set; }

        public DateTime DataZakonczeniaPracy { get; set; } 

        public string DziennyCzasPracy { get; set; }

        public double IloscPrzepracowanychDni { get; set; }

    }
}
