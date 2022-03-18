using Kartotekapracownikow.DatabaseModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Employees
{
    public partial class Employees : Form
    {
        private static Employees _instance = null;

        public static Employees Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Employees();
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

        private Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dodanie scrollBar do panelu
            panelPracownicy.AutoScroll = true;
            panelPracownicy.HorizontalScroll.Enabled = false;
            panelPracownicy.HorizontalScroll.Visible = false;
            panelPracownicy.HorizontalScroll.Maximum = 0;
        }

        private void krajowiPracownicyBTN_Click(object sender, EventArgs e)
        {
            int height;
            dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height * 2;
            Bitmap bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));

            using(var db = new Database())
            {
                var collection = new DanePracownikaPodstawowe();

                
            }
        }
    }
}
