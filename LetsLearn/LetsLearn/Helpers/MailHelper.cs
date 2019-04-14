using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace LetsLearn.Helpers
{
    public class MailHelper
    {
        public static bool Send(string from, string pass, string subject, string content)
        {
            try
            {
                var buiulder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

                var configuration = buiulder.Build();
                var host = configuration["Gmail:Host"];
                var port = int.Parse(configuration["Gmail:Port"]);
                var to = configuration["Gmail:UserName"];
               
                var enable = bool.Parse(configuration["Gmail:SMTP:starttls:enable"]);
                var smtpClient = new SmtpClient(host, port);

                smtpClient.EnableSsl = enable;
                smtpClient.Credentials = new NetworkCredential(from, pass);

                MailMessage message = new MailMessage(from, to, subject, content);
                message.IsBodyHtml = true;

                smtpClient.Send(message);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
