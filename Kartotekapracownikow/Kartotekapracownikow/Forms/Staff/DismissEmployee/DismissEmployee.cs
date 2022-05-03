using Kartotekapracownikow.DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.DismissEmployee
{
    public partial class DismissEmployee : Form
    {
        private static DismissEmployee _instance = null;

        public static DismissEmployee Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DismissEmployee();
                }
                return _instance;
            }
        }

        public static bool truOrFalseInstance
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private DismissEmployee()
        {
            InitializeComponent();
            WczytanieDanych();
        }

        private void WczytanieDanych()
        {
            using (var db = new Database())
            {
                try
                {
                    var querry = (from collection in db.DanePracownikaPodstawowe
                                  select new
                                  {
                                      collection.ID,
                                      collection.Imie,
                                      collection.Nazwisko,
                                      collection.ImieMatki,
                                      collection.ImieOjca,
                                      collection.NumerTelefonu,
                                      collection.DataUrodzenia,
                                      collection.Miejscowosc,
                                      collection.Ulica
                                  }).ToList();

                    daneDGW.DataSource = querry;
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd podczas wyświetlania");
                }
            }
        }

        private void DismissEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zwolnijPracownikaGB();
        }

        private void zwolnijPracownikaGB()
        {
            
        }
    }
}
