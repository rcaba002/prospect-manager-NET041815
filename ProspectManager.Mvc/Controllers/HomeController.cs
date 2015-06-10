using System;
using System.Linq;
using System.Web.Mvc;
using ProspectManager.Mvc.Models;
using ProspectManager.Mvc.Models.Home;

namespace ProspectManager.Mvc.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult Index()
        {
            var threeDaysFromNow = DateTime.Now.AddDays(3);

            var model = new IndexViewModel {
                UpcomingTodos = db.TodoItems
                    .Where(x => !x.Completed)
                    .OrderBy(x => x.DueDate)
                    .Take(10)
                    .ToList(),
                UpcomingMeetings = db.Meetings
                    .Where(x => x.MeetingDate >= DateTime.Now && 
                        x.MeetingDate < threeDaysFromNow)
                    .OrderBy(x => x.MeetingDate)
                    .Take(1000)
                    .ToList()
            };

            return View(model);
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