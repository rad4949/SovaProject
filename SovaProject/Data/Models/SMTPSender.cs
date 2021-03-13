using System;
using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using EASendMail;

namespace SovaProject.Data.Models
{
    public class SMTPSender : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public async Task<bool> SendMessage(string email, string html)
        {
            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress("Администрация сайта", "ihor@karpaty.tk"));
                emailMessage.To.Add(new MailboxAddress("", email));
                emailMessage.Subject = "Нове замовлення";
                emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {
                    Text = html
                };
                //using (var client = new SmtpClient())
                //{
                //    await client.ConnectAsync("smtp.gmail.com", 587, false);
                //    await client.AuthenticateAsync("igor16radchuk@gmail.com", "DDwwJJuuyy3498");
                //    await client.SendAsync(emailMessage);
                //    await client.DisconnectAsync(true);
                //}
                //SmtpServer server = new SmtpServer("smtp.gmail.com")
                //{
                //    Port = 587,
                //    ConnectType = SmtpConnectType.ConnectSSLAuto,
                //    User = "itstudentyre@gmail.com",
                //    Password = "Qw3eI98*63%"
                //};


                //MailMessage mail = new MailMessage();
                //mail.From = new MailAddress("igor16radchuk@gmail.com");
                //mail.To.Add("igor12radchuk@gmail.com");
                //mail.Subject = "Нове замовлення";
                //mail.SubjectEncoding = System.Text.Encoding.UTF8;
                //mail.IsBodyHtml = true;

                //mail.BodyEncoding = System.Text.Encoding.UTF8;
                //mail.Body = html;
                //System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
                //{
                //    Credentials = new NetworkCredential("igor16radchuk@gmail.com", "DDwwJJuuyy3498"),
                //    EnableSsl = true
                //};
                //client.Send(mail);


                EASendMail.SmtpServer server = new EASendMail.SmtpServer("smtp.gmail.com")
                {
                    Port = 587,
                    ConnectType = SmtpConnectType.ConnectSSLAuto,
                    User = "igor16radchuk@gmail.com",
                    Password = "DDwwJJuuyy3498"
                };
                SmtpMail message = new SmtpMail("TryIt")
                {
                    From = server.User,
                    To = email,
                    Subject = "Verification code with Win Viewer",
                    //TextBody = html,
                    Priority = EASendMail.MailPriority.High,
                    HtmlBody = html
                };
                EASendMail.SmtpClient client = new EASendMail.SmtpClient();
                client.SendMail(server, message);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
