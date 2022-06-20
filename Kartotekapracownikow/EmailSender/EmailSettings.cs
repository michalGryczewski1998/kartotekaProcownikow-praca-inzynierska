using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailSender
{
    public class EmailSettings
    {
        private SmtpClient _smtp;
        private MailMessage _mail;

        private string _hostSmpt;
        private bool _enableSsl;
        private int _port;
        private string _senderEmail;
        private string _senderEmailPassword;
        private string _senderName;

        public EmailSettings(EmailParameters emailParameters)
        {
            _hostSmpt = emailParameters.HostSmtp;
            _enableSsl = emailParameters.EnableSsl;
            _port = emailParameters.Port;
            _senderEmail = emailParameters.SenderEmail;
            _senderEmailPassword = emailParameters.SenderEmailPassword;
            _senderName = emailParameters.SenderName;
        }

        public async Task WysylkaEmail(string odbiorca, string temat, string tresc)
        {
            _mail = new MailMessage();
            _mail.From = new MailAddress(_senderEmail, _senderName);
            _mail.To.Add(new MailAddress(odbiorca));
            _mail.Subject = temat;
            _mail.BodyEncoding = System.Text.Encoding.UTF8;
            _mail.SubjectEncoding = System.Text.Encoding.UTF8;
            _mail.Body = tresc;

            _smtp = new SmtpClient
            {
                Host = _hostSmpt,
                EnableSsl = _enableSsl,
                Port = _port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_senderEmail, _senderEmailPassword)
            };

            _smtp.SendCompleted += OnSendCompleted;

            await _smtp.SendMailAsync(_mail);
        }

        private void OnSendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            _smtp.Dispose();
            _mail.Dispose();
        }
    }
}
