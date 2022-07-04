using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartotekapracownikow.DatabaseModel
{
    public class DanePracownikZagranicznyPodstawowe
    {
        [Key()]
        public int ID { get; set; }

        public string Imie
        {
            get;
            set;
        }

        public string Nazwisko
        {
            get;
            set;
        }

        public string ImieMatki
        {
            get;
            set;
        }

        public string ImieOjca
        {
            get;
            set;
        }

        public string MiejsceUrodzenia
        {
            get;
            set;
        }

        public DateTime DataUrodzenia
        {
            get;
            set;
        }

        public string KrajPochodzenia
        {
            get;
            set;
        }

        public string Miejscowosc
        {
            get;
            set;
        }

        public string Gmina
        {
            get;
            set;
        }

        public string KodPocztowy
        {
            get;
            set;
        }

        public string Poczta
        {
            get;
            set;
        }

        public string Ulica
        {
            get;
            set;
        }

        public string DomMieszkanie
        {
            get;
            set;
        }

        public string KrajZamieszkania
        {
            get;
            set;
        }

        public string PodzialAdministracyjny
        {
            get;
            set;
        }

        public string ZdjeciePracownika
        {
            get;
            set;
        }

        public string TelefonKontaktowy
        {
            get;
            set;
        }

        public string AdresEmail
        {
            get;
            set;
        }

        public string OsobaZaufana
        {
            get;
            set;
        }

        public string NumerTelefonuOsobyZaufanej
        {
            get;
            set;
        }

        public virtual DanePracownikZagranicznyZatrudnienie ZatrudnienieZagraniczny
        {
            get;
            set;
        }
    }
}
