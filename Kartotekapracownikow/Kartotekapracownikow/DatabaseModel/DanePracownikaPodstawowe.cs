using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartotekapracownikow.DatabaseModel
{
    public class DanePracownikaPodstawowe
    {
        public int ID { get; set; }

        public string Nazwisko { get; set; }

        public string Imie { get; set; }

        public string ZdjeciePracownika { get; set; }

        public DateTime DataUrodzenia { get; set; }

        public string NumerTelefonu { get; set; }

        public string AdresEmail { get; set; }

        public string MiejsceUrodzenia { get; set; }

        public string Plec { get; set; }

        public string ImieMatki { get; set; }

        public string ImieOjca { get; set; }

        public string PESEL { get; set; }

        public string NIP { get; set; }

        public string Kraj { get; set; }

        public string Wojewodztwo { get; set; }

        public string Gmina { get; set; }

        public string KodZamieszkania { get; set; }

        public string Miejscowosc { get; set; }

        public string Ulica { get; set; }

        public string NumerDomu { get; set; }

        public string NumerLokalu { get; set; }

        public string Poczta { get; set; }

        public string DoKogoWNaglymWypadku { get; set; }

        public string NumerNagleWypadki { get; set; }

        public virtual ICollection<DanePracownikaZatrudnienie> Zatrudnienie { get; set; }
    }
}
