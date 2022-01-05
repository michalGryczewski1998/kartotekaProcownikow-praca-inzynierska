using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartotekapracownikow.ModelOfView
{
    public class EmployeeModel
    {
        private string imiePracownika;

        private string nazwiskoPracownika;

        public int Id { get; set; }

        public string Imie {
            get { return imiePracownika.ToUpper(); } // imie bedzie z duzej litery
            set { imiePracownika = value; } 
        }

        public string Nazwisko { 
            get { return nazwiskoPracownika.ToUpper(); }
            set { nazwiskoPracownika = value; } 
        }

        public string Dzial { get; set; }

        public string Stanowisko { get; set; }

        public string Staz { get; set; }


    }
}
