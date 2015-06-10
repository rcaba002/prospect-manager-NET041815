using ProspectManager.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProspectManager.Mvc.Controllers
{
    public class MeetingsContactsController : Controller
    {
        DataContext db = new DataContext();

        // GET: MeetingsContacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MeetingsContacts/Create
        public ActionResult Create(int id)
        {
            var meeting = db.Meetings.Find(id);
            ViewBag.ContactList = db.Contacts.ToList();
            return View(meeting);
        }

        // POST: MeetingsContacts/Create
        [HttpPost]
        public ActionResult Create(int id, List<int> contactIdList)
        {
            try
            {
                var meeting = db.Meetings.Find(id);
                var selectedContacts = db.Contacts
                    .Where(x => contactIdList.Contains(x.Id))
                    .ToList();

                foreach (var contact in selectedContacts)
                {
                    meeting.Contacts.Add(contact);
                }

                db.SaveChanges();

                return RedirectToAction("Details", "Meetings", new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: MeetingsContacts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MeetingsContacts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MeetingsContacts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MeetingsContacts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
