using EmailSender;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Email
{
    public partial class EmailMessage : Form
    {
        private string emailAdres;
        private string temat;
        private string tresc;
        private string zalacznikPath;

        public EmailMessage(string email)
        {
            this.emailAdres = email;
            InitializeComponent();

            CzynnosciStartowe();
        }
        private void CzynnosciStartowe()
        {
            AdresOdbiorcyTB.Text = emailAdres;
        }

        private void AdresOdbiorcyTB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdresOdbiorcyTB.Text))
            {
                AdresOdbiorcyTB.Focus();
                EmailOdbiorcaEP.SetError(AdresOdbiorcyTB, "AProszę podać adres E-mail");
            }
            else
            {
                bool info = SprawdzaniePoprawnosciEmail();

                switch (info)
                {
                    case true:
                        EmailOdbiorcaEP.SetError(AdresOdbiorcyTB, null);
                        break;
                    case false:
                        EmailOdbiorcaEP.SetError(AdresOdbiorcyTB, "Proszę wprowadzić poprawny adres E-mail");
                        break;
                    default:
                        throw new InvalidOperationException();

                }
;            }
        }

        public bool SprawdzaniePoprawnosciEmail()
        {
            if (AdresOdbiorcyTB.Text.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emailAdres = AdresOdbiorcyTB.Text;
            temat = TematTB.Text;
            tresc = TrescTB.Text;

            _ = WysylkaEmail();
        }

        private async Task WysylkaEmail()
        {
            var email = new EmailSettings(new EmailParameters
            {
                HostSmtp = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                SenderName = "Michał",
                SenderEmail = "pracakartotekapracownikow@gmail.com",
                SenderEmailPassword = "pmlnmihwhcutttvi"
            });

            await email.WysylkaEmail(
                emailAdres,
                temat,
                tresc);
        }
    }
}
