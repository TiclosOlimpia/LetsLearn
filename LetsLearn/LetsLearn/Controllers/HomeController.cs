using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LetsLearn.Models;
using LetsLearn.Data;
using LetsLearn.Helpers;
using LetsLearn.Repos;
using MimeKit;
using MailKit.Net.Smtp;
using EASendMail;
using SmtpClient = System.Net.Mail.SmtpClient;

namespace LetsLearn.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _context;

        public HomeController(IRepository userRepository)
        {
            _context = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            if (Request.Cookies.ContainsKey("Id"))
            {
                string id = Request.Cookies["Id"].ToString();
                User user = await _context.GetById<User>(id);
                @ViewBag.email = user.EmailAddress;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactModel model)
        {
            /*
                var extension = model.EmailAddress.ToString().Split("@")[1];
                if (extension == "gmail.com")
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress(address: model.EmailAddress.ToString()));
                    message.To.Add(new MailboxAddress(address: "oli.olimpia29@gmail.com"));
                    message.Subject = model.Subject.ToString();
                    message.Body = new TextPart()
                    {
                        Text = model.Continut.ToString()
                    };
                    using (var client = new MailKit.Net.Smtp.SmtpClient())
                        {
                            client.Connect("smtp.gmail.com", 587, false);
                            client.Authenticate(userName: model.EmailAddress.ToString(),
                                password: model.Password.ToString());

                            try
                            {
                            client.Send(message);
                            client.Disconnect(true);
                            @ViewBag.msg = "Succes";
                            }
                            catch (Exception e)
                            {
                                @ViewBag.msg = "Eroare";
                            }

                        }
                }
                else
                {
                    EASendMail.SmtpClient client = new EASendMail.SmtpClient();
                    EASendMail.SmtpMail mail = new EASendMail.SmtpMail("TryIt");

                    mail.From = model.EmailAddress.ToString();
                    mail.To = "oli.olimpia29@gmail.com";
                    mail.Subject = model.Subject.ToString();
                    mail.TextBody = model.Continut.ToString();

                    EASendMail.SmtpServer server = new EASendMail.SmtpServer("smtp.mail.yahoo.com");

                    server.User = model.EmailAddress.ToString();
                    server.Password = model.Password.ToString();
                    server.Port = 465;
                    server.ConnectType = SmtpConnectType.ConnectSSLAuto;
                    try
                    {
                        client.SendMail(server, mail);
                        @ViewBag.msg = "Success";
                }
                    catch (Exception e)
                    {
                    @ViewBag.msg = "Eroare";
                    }

                }


        */


            var extension = model.EmailAddress.ToString().Split("@")[1];

            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("fromadresa",model.EmailAddress.ToString()));
                message.To.Add(new MailboxAddress("toadresa","oli.olimpia29@gmail.com"));
                message.Subject = model.Subject.ToString();
                message.Body = new TextPart("plain")
                {
                    Text = model.Continut.ToString()
                };
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    if (extension == "gmail.com")
                    {
                        client.Connect("smtp.gmail.com", 587, false);
                    }
                    else
                    {
                        client.Connect("smtp.mail.yahoo.com", 465, false);
                    }

                    client.Authenticate(model.EmailAddress.ToString(),model.Password.ToString());


                    client.Send(message);
                    client.Disconnect(true);
                    @ViewBag.msg = "Succes";
                }
            }
            catch (Exception e)
            {
                @ViewBag.msg = "Eroare";
            }

   
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
