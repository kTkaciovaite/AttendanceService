using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceService.WebApp.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}