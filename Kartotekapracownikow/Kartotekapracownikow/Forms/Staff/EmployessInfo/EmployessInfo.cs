using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.EmployessInfo
{
    public partial class EmployessInfo : Form
    {
        private int danePracownikaID;

        public EmployessInfo(int danePracownikaID)
        {
            this.danePracownikaID = danePracownikaID;
            InitializeComponent();
        }

        private void EmployessInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
