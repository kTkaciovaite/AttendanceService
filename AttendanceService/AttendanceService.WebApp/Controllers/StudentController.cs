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
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        StudentDataService _studentDataService;
        LectureDataService _lectureDataService;
        GroupDataService _groupDataService;
        AttendanceDataService _attendanceDataService;

        public StudentController()
        {
            ViewBag.Today = new DateTime(2018, 4, 16);

            _studentDataService = new StudentDataService();
            _lectureDataService = new LectureDataService();
            _groupDataService = new GroupDataService();
            _attendanceDataService = new AttendanceDataService();
        }

        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            if (userId == null || userId == "")
            {
                return View();
            }

            var lectures = _getLectures(userId);

            return View(lectures);
        }

        public ActionResult Attendance()
        {
            var userId = User.Identity.GetUserId();

            if (userId == null || userId == "")
            {
                return View();
            }

            var student = _studentDataService.GetByUserId(userId);
            var group = _groupDataService.GetByStudent(student.Id);
            var lectures = _lectureDataService.GetByGroupId(group.Id);

            var attendanceStats = new List<StudentAttendanceViewModel>();

            var generalStats = new StudentAttendanceViewModel
            {
                Subject = "General",
                LectureCount = _getOccurencesCount(lectures),
                AttendedLecturesCount = _getAttendedLecturesCount(lectures, student)
            };
            attendanceStats.Add(generalStats);

            foreach (var lecture in lectures)
            {
                var attended = _attendanceDataService.GetStudentAttendance(student.Id, lecture.Id);

                if (attendanceStats.Any(x => x.Subject == lecture.Subject.Name))
                {
                    attendanceStats.FirstOrDefault(x => x.Subject == lecture.Subject.Name).LectureCount += lecture.Occurences.Count;
                    attendanceStats.FirstOrDefault(x => x.Subject == lecture.Subject.Name).AttendedLecturesCount += 
                        attended.AttendedLectures == "" ? 0 : attended.AttendedLectures.Split(',').Count();
                }
                else
                {
                    var stats = new StudentAttendanceViewModel
                    {
                        Subject = lecture.Subject.Name,
                        LectureCount = lecture.Occurences.Count,
                        AttendedLecturesCount = attended.AttendedLectures == "" ? 0 : attended.AttendedLectures.Split(',').Count()
                    };
                    attendanceStats.Add(stats);
                }
            }

            return View(attendanceStats);
        }

        public ActionResult FutureLectures()
        {
            var userId = User.Identity.GetUserId();

            if (userId == null || userId == "")
            {
                return View();
            }

            var lectures = _getLectures(userId).Where(x => x.Date > ViewBag.Today).OrderBy(x => x.Date).ToList();

            return View(lectures);
        }

        public ActionResult PastLectures()
        {
            var userId = User.Identity.GetUserId();

            if (userId == null || userId == "")
            {
                return View();
            }

            var lectures = _getLectures(userId).Where(x => x.Date < ViewBag.Today).OrderBy(x => x.Date).ToList();

            return View(lectures);
        }

        public ActionResult TodaysLectures()
        {
            var userId = User.Identity.GetUserId();

            if (userId == null || userId == "")
            {
                return View();
            }

            var lectures = _getLectures(userId).Where(x => x.Date.ToShortDateString() == ViewBag.Today.ToShortDateString())
                .OrderBy(x => x.Date).ToList();

            return View(lectures);
        }

        private List<StudentLectureViewModel> _getLectures(string userId)
        {
            var student = _studentDataService.GetByUserId(userId);
            var group = _groupDataService.GetByStudent(student.Id);
            var lectures = _lectureDataService.GetByGroupId(group.Id);

            var mappedLectures = new List<StudentLectureViewModel>();

            foreach (var lecture in lectures)
            {
                var lectureAttendance = _attendanceDataService.GetStudentAttendance(student.Id, lecture.Id);

                foreach (var occurence in lecture.Occurences)
                {
                    var mappedLecture = new StudentLectureViewModel
                    {
                        Id = lecture.Id,
                        Auditorium = lecture.Auditorium.Name,
                        Lecturer = lecture.Lecturer.Name + " " + lecture.Lecturer.Surname,
                        Date = occurence.Date,
                        LectureTime = lecture.LectureTime,
                        LectureType = lecture.LectureType.Type,
                        Subject = lecture.Subject,
                        Group = lecture.Group,
                        IsAttended = lectureAttendance.AttendedLectures.Contains(occurence.Date.ToString("yyyy-MM-dd"))
                    };

                    mappedLectures.Add(mappedLecture);
                }
            }

            return mappedLectures;
        }

        private int _getOccurencesCount(List<Lecture> lectures)
        {
            var count = 0;
            foreach (var lecture in lectures)
            {
                count += lecture.Occurences.Count;
            }

            return count;
        }

        private int _getAttendedLecturesCount(List<Lecture> lectures, Student student)
        {
            var count = 0;

            foreach (var lecture in lectures)
            {
                var attended = _attendanceDataService.GetStudentAttendance(student.Id, lecture.Id);

                count += attended.AttendedLectures == "" ? 0 : attended.AttendedLectures.Split(',').Count();
            }

            return count;
        }
    }
}