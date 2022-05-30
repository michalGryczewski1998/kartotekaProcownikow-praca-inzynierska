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

namespace Kartotekapracownikow.Forms.Staff.FormerEmployeesInfo
{
    public partial class FormerInfo : Form
    {
        int employeesID;

        public FormerInfo(int employesID)
        {
            InitializeComponent();
            this.employeesID = employesID;
        }

        private void ZapytanieZwolnionyPracownik()
        {
            using(var db = new Database())
            {
                var query = (from zwolnieni in db.ZwolnieniPracownicy
                             where zwolnieni.ID == employeesID
                             select new
                             {
                                 zwolnieni.Imie,
                                 zwolnieni.Nazwisko,
                                 zwolnieni.Kraj,
                                 zwolnieni.NumerTelefonu,
                                 zwolnieni.Umowa,
                                 zwolnieni.Etat,
                                 zwolnieni.Dzial,
                                 zwolnieni.Stanowisko,
                                 zwolnieni.StawkaGodzinowa,
                                 zwolnieni.DziennyCzasPracy,
                                 zwolnieni.IloscPrzepracowanychDni,
                                 zwolnieni.DataRozpoczeciaPracy,
                                 zwolnieni.DataZakonczeniaPracy
                             }).ToList();
            }
        }
    }
}
