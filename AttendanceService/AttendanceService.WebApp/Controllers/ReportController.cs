using AttendanceService.DataAccess;
using AttendanceService.Domain;
using AttendanceService.WebApp.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AttendanceService.WebApp.Controllers
{
    [Authorize(Roles = "Lecturer")]
    public class ReportController : Controller
    {
        private LecturerDataService _lecturerDataService;
        private LectureDataService _lectureDataService;
        private AttendanceDataService _attendanceDataService;
        private GroupDataService _groupDataService;

        public ReportController()
        {
            ViewBag.Today = new DateTime(2018, 4, 16);

            _lectureDataService = new LectureDataService();
            _lecturerDataService = new LecturerDataService();
            _attendanceDataService = new AttendanceDataService();
            _groupDataService = new GroupDataService();
        }

        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            if (userId == null || userId == "")
            {
                return View();
            }

            var lecturer = _lecturerDataService.GetByUserId(userId);
            var lectures = _lectureDataService.GetByLecturerId(lecturer.Id);

            var subjects = new List<Subject>();

            foreach(var lecture in lectures)
            {
                if (!subjects.Any(x => x.Id == lecture.Subject.Id))
                {
                    subjects.Add(lecture.Subject);
                }
            }

            return View(subjects);
        }

        public ActionResult SubjectAttendance(int id)
        {
            var userId = User.Identity.GetUserId();
            var subjectId = id;

            if (userId == null || userId == "")
            {
                return View();
            }

            var lecturer = _lecturerDataService.GetByUserId(userId);
            var lectures = _lectureDataService.GetByLecturerId(lecturer.Id).Where(x => x.Subject.Id == subjectId);

            var reportData = new List<ReportSubjectAttendance>();

            foreach (var lecture in lectures)
            {
                var group = _groupDataService.GetById(lecture.Group.Id);

                foreach (var student in group.Students)
                {
                    var studentAttendance = _attendanceDataService.GetStudentAttendance(student.Id, lecture.Id);
                    var attendedLecturesCount = studentAttendance.AttendedLectures.Split(',').Count();

                    var reportItem = new ReportSubjectAttendance
                    {
                        StudentNumber = student.StudentId,
                        Student = student.Name + " " + student.Surname,
                        Group = lecture.Group.Name,
                        AttendedLecturesCount = attendedLecturesCount,
                        LecturesCount = lecture.Occurences.Count()
                    };

                    reportData.Add(reportItem);
                }
            }

            return View(reportData);
        }
    }
}