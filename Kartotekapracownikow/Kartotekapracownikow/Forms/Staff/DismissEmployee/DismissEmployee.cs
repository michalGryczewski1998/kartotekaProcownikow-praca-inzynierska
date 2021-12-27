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
        }

        private void DismissEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
