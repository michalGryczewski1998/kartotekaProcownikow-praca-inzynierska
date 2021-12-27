using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.FormerEmployees
{
    public partial class FormerEmployees : Form
    {

        private static FormerEmployees _instance = null;

        public static FormerEmployees Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new FormerEmployees();
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

        private FormerEmployees()
        {
            InitializeComponent();
        }

        private void FormerEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
