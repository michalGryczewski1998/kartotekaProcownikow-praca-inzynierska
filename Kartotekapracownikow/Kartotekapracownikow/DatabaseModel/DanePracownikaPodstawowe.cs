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
        [Required]
        [Range(0, 10000)]
        public int ID { get; set; }

        [Required, RegularExpression(@"^.*[a-zA-Z]",ErrorMessage = "Proszę wpisać poprawne Nazwisko !")]
        public string Nazwisko { get; set; }

        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Proszę wpisać poprawne Imię !")]
        public string Imie { get; set; }

        [Required]
        public string ZdjeciePracownika { get; set; }

        [Required]
        public DateTime DataUrodzenia { get; set; }

        [Required, Phone]
        public string NumerTelefonu { get; set; }

        [Required, EmailAddress]
        public string AdresEmail { get; set; }

        [Required]
        public string MiejsceUrodzenia { get; set; }

        [Required]
        public string Plec { get; set; }

        [Required]
        public string ImieMatki { get; set; }

        [Required]
        public string ImieOjca { get; set; }

        [Required]
        public string PESEL { get; set; }

        [Required]
        public string NIP { get; set; }

        [Required]
        public string Kraj { get; set; }

        [Required]
        public string Wojewodztwo { get; set; }

        [Required]
        public string Gmina { get; set; }

        [Required]
        public string KodZamieszkania { get; set; }

        [Required]
        public string Miejscowosc { get; set; }

        [Required]
        public string Ulica { get; set; }

        public string NumerDomu { get; set; }

        public string NumerLokalu { get; set; }

        [Required]
        public string Poczta { get; set; }

        [Required]
        public string DoKogoWNaglymWypadku { get; set; }

        [Required, Phone]
        public string NumerNagleWypadki { get; set; }

        public virtual ICollection<DanePracownikaZatrudnienie> Zatrudnienie { get; set; }
    }
}
