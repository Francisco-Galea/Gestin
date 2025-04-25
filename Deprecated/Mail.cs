using MailKit.Net.Smtp;
using MimeKit;


namespace Gestin.Deprecated
{
    internal class Mail
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }


        public Mail(string senderMail, string password, string host, int port)
        {
            smtpClient = new SmtpClient();
            this.senderMail = senderMail;
            this.password = password;
            this.host = host;
            this.port = port;
        }

        public bool sendMail(string header, string subject, BodyBuilder bodyMessage, InternetAddressList recipientMail)
        {

            MimeMessage mensaje = new MimeMessage();
            try
            {
                mensaje.From.Add(new MailboxAddress(header, senderMail));
                foreach (InternetAddress mail in recipientMail)
                {
                    mensaje.To.Add(mail);
                }
                mensaje.Subject = subject;
                mensaje.Body = bodyMessage.ToMessageBody();

                smtpClient.CheckCertificateRevocation = false;
                smtpClient.Connect(host, port, MailKit.Security.SecureSocketOptions.StartTls);
                smtpClient.Authenticate(senderMail, password);
                smtpClient.Send(mensaje);
                smtpClient.Disconnect(true);
                return true;
            }
            catch (Exception) { throw; }
            finally
            {
                mensaje.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
