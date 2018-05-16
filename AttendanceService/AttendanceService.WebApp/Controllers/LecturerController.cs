using AttendanceService.DataAccess;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace AttendanceService.WebApp.Controllers
{
    [Authorize(Roles = "Lecturer")]
    public class LecturerController : Controller
    {
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            var lecturerDataService = new LecturerDataService();
            var lecturer = lecturerDataService.GetByUserId(userId);

            var lectureDataService = new LectureDataService();
            var lectures = lectureDataService.GetByLecturerId(lecturer.Id);
            
            return View(lectures);
        }
    }
}