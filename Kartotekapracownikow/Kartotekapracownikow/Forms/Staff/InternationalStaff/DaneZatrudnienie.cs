using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Staff.InternationalStaff
{
    public partial class DaneZatrudnienie : Form
    {
        private string PdfToBase64;

        public DaneZatrudnienie()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typWybrany = TypZezwoleniaCB.SelectedIndex;

            switch (typWybrany)
            {
                case 0:
                    TypZezwoleniaInformacjaTB.Text = $"Wniosek o zezwolenie na pracę TYP A składasz kiedy Twój pracownik będzie wykonywał pracę w Polsce, " +
                        $"a Ty prowadzisz działalność na terytorium RP.";
                    break;
                case 1:
                    TypZezwoleniaInformacjaTB.Text = $"Wniosek o zezwolenie na pracę TYP B składasz kiedy Cudzoziemiec pełni funkcję w zarządzie " +
                        $"osoby prawnej wpisanej do rejestru przedsiębiorców lub będącej spółką kapitałową w organizacji albo prowadzi sprawy spółki komandytowej " +
                        $"lub komandytowo-akcyjnej jako komplementariusz, albo w związku z udzieleniem mu prokury przez okres przekraczający łącznie 6 miesięcy w ciągu kolejnych 12 miesięcy.";
                    break;
                case 3:
                    TypZezwoleniaInformacjaTB.Text = $"Zezwolenie to jest wydawane gdy pracownik, wykonuje pracę u pracodawcy zagranicznego i jest delegowany na terytorium " +
                        $"Rzeczypospolitej Polskiej na okres przekraczający 30 dni w roku kalendarzowym do oddziału lub zakładu " +
                        $"podmiotu zagranicznego albo podmiotu powiązanego, w rozumieniu ustawy z dnia 26 lipca 1991 r. o podatku dochodowym od osób fizycznych, z pracodawcą zagranicznym.";
                    break;
                case 4:
                    TypZezwoleniaInformacjaTB.Text = $"Zezwolenie na pracę typ jest wymagane jeśli Cudzoziemiec, wykonuje pracę u pracodawcy zagranicznego nieposiadającego oddziału, zakładu " +
                        $"lub innej formy zorganizowanej działalności na terytorium Rzeczypospolitej Polskiej i jest delegowany na terytorium Rzeczypospolitej Polskiej w celu realizacji " +
                        $"usługi o charakterze tymczasowym i okazjonalnym (usługa eksportowa).";
                    break;
                case 5:
                    TypZezwoleniaInformacjaTB.Text = $"Zezwolenie na pracę typ E jest wymagane jeśli Cudzoziemiec wykonuje pracę u pracodawcy zagranicznego i jest delegowany na terytorium " +
                        $"Rzeczypospolitej Polskiej na okres przekraczający 30 dni w ciągu kolejnych 6 miesięcy w innym celu niż wskazany w zezwoleniach typu B, C, D.";
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "PDF Files|*.pdf";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileArray = System.IO.File.ReadAllBytes(open.FileName);
                    PdfToBase64 = Convert.ToBase64String(fileArray);
                }

                Debug.WriteLine(PdfToBase64);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas dodawania dokumentu.");
            }
        }
    }
}
