using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web.Mvc;
using ProspectManager.Mvc.Models;
using ProspectManager.Mvc.Models.Contacts;
using System.Net;
using System.Data.Entity.Infrastructure;

namespace ProspectManager.Mvc.Controllers
{
    public class ContactsController : Controller
    {
        DataContext db = new DataContext();

        // GET: Contact
        public ActionResult Index()
        {
            return View(db.Contacts.ToList());
        }

        public ActionResult FilteredBy(string id)
        {
            return View("Index", db.Contacts
                .Where(x => x.Name.StartsWith(id))
                .ToList());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var contact = db.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some errors");
                return View(contact);
            }

            Contact retreivedContact = db.Contacts.Find(contact.Id);
            retreivedContact.Name = contact.Name;
            retreivedContact.BirthDate = contact.BirthDate;
            retreivedContact.Email = contact.Email;

            try
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("Email", "No Dupes Allowed");
                return View(contact);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,BirthDate")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}