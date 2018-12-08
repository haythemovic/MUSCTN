using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MUSCTN_MVC.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }

        // GET: Email/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Email/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Email/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string senderEmail, string password, string subject, string message)
        {
            var senderemail = new MailAddress(senderEmail, "Map User");
            var recieveremail = new MailAddress("haythemovic.17@live.fr");
            var pass = password;

            var sub = subject;
            var body = message;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderemail.Address, pass)
            };
            using (var mess = new MailMessage(senderemail, recieveremail)
            {
                Subject = subject,
                Body = body
            }
                )
            {
                smtp.Send(mess);
            }
            return View();
        }

 
    }
}