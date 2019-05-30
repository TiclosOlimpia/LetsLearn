using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.Configuration;

namespace LetsLearn.Helpers
{
    public class MailHelper
    {
        public static bool Send(string from, string to, string subject, string content)
        {
            try
            {
                var buiulder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");

                var configuration = buiulder.Build();
                var host = configuration["Gmail:Host"];
                var port = int.Parse(configuration["Gmail:Port"]);
                var servfrom = configuration["Gmail:UserName"];
                var pass = configuration["Gmail:Password"];

                var enable = bool.Parse(configuration["Gmail:SMTP:starttls:enable"]);
                var smtpClient = new SmtpClient(host, port);

                smtpClient.EnableSsl = enable;
                smtpClient.Credentials = new NetworkCredential(servfrom, pass);

                content = "From: " + from + "\n" + content;

                if (to == "me")
                {
                    var servTo = configuration["Gmail:UserName"];
                    MailMessage message = new MailMessage(servfrom, servTo.ToString(), subject, content);
                    message.IsBodyHtml = true;
                    smtpClient.Send(message);
                }
                else
                {
                     MailMessage message = new MailMessage(servfrom, to, subject, content);
                     message.IsBodyHtml = true;
                     smtpClient.Send(message);
                }

               
                
     

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
       
    }
}
