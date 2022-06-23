using Kartotekapracownikow.Forms.Staff.InternationalStaff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.InternationalStaff
{
    public partial class InternationalStaff : Form
    {
        private static InternationalStaff _instance = null;

        public static InternationalStaff Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new InternationalStaff();
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

        private InternationalStaff()
        {
            InitializeComponent();
        }

        private void InternationalStaff_Load(object sender, EventArgs e)
        {

        }

        private void DodajBTN_Click(object sender, EventArgs e)
        {
            DaneZatrudnienie zatrudnienie = new DaneZatrudnienie();
            zatrudnienie.ShowDialog();
        }
    }
}
