using ContactMVC.Dal;
using ContactMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactMVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View(new ContactMessage());
        }
        [HttpPost]
        public ActionResult Index(ContactMessage post)
        {
            if(ModelState.IsValid)
            {
                //TODO: Save to database
                ContactDal obj = new ContactDal();
                post.DateSent = DateTime.Now.ToString();
                obj.ContactMessages.Add(post);
                obj.SaveChanges();
                TempData["ContactMessage"] = post;
               return RedirectToAction("SucessMessage");//Redirect

            }
            return View(post);
        }

        public ActionResult SucessMessage()
        {
            var message = (ContactMessage)TempData["ContactMessage"];
            return View(message);
        }

        [Authorize]
        public ActionResult Log()
        {
            var messages = new List<ContactMessage>();
            using (var db = new ContactDal())
            {
                messages.AddRange(db.ContactMessages.ToArray());
            }
            return View(messages);

        }
    }
}