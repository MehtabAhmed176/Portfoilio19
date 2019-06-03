using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Portfoilio19.Models;
namespace Portfoilio19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page...";

            return View();
        }

      


        public ActionResult Skill()
        {


            return View();
        }

      
       
  public ActionResult Projects()
        {


            return View();
        }
        public ActionResult Contact()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("ahmedmehtab176@gmail.com"));  // replace with valid value 
                message.From = new MailAddress("rohaib99hassan@gmail.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                try
                {
                    using (var smtp = new SmtpClient())
                    {
                        var credential = new System.Net.NetworkCredential
                        {
                            UserName = "ahmedmehtab176@gmail.com",  // replace with valid value
                            Password = "hellodubai"  // replace with valid value
                        };
                        smtp.Credentials = credential;
                        smtp.Host = "smtp.gmail.com";

                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(message);
                        return RedirectToAction("Sent");
                    }
                }
                catch (Exception)
                {
                    return RedirectToAction("sendfailed");

                }


            }
            return View(model);
        }
        public ActionResult Sent()
        {

            return View();
        }


        public ActionResult sendfailed()
        {
            ViewBag.error = "Oop! Message has been blocked by Mehtab temporaily due to secirty reasons ";
            ViewBag.message = "Will be back soon, have a Good day ,Bye for Now!";

            return View();
        }
        public ActionResult DownloadCV()
        {
            string path = "";
            var content_type = "";
            path = Path.Combine(@"C:\Users\ROG\source\repos\Portfoilio19\Files\mehtablatest.pdf");

           
                content_type = "application/pdf";
           
            return File(path, content_type);
            // return View();
        }

    }
}