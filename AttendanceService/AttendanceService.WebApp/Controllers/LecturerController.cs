using AttendanceService.DataAccess;
using AttendanceService.WebApp.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AttendanceService.WebApp.Controllers
{
    [Authorize(Roles = "Lecturer")]
    public class LecturerController : Controller
    {
        private LectureDataService _lectureDataService;
        private LecturerDataService _lecturerDataService;
        private GroupDataService _groupDataService;
        private AttendanceDataService _attendanceDataService;

        public LecturerController()
        {
            ViewBag.Today = new DateTime(2018, 4, 16);

            _lectureDataService = new LectureDataService();
            _lecturerDataService = new LecturerDataService();
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
            
            var lecturer = _lecturerDataService.GetByUserId(userId);
            var lectures = _lectureDataService.GetByLecturerId(lecturer.Id);

            var mappedLectures = new List<LectureViewModel>();

            foreach(var lecture in lectures)
            {
                foreach (var occurence in lecture.Occurences)
                {
                    var mappedLecture = new LectureViewModel
                    {
                        Id = lecture.Id,
                        Auditorium = lecture.Auditorium.Name,
                        Lecturer = lecture.Lecturer.Name + " " + lecture.Lecturer.Surname,
                        Date = occurence.Date,
                        LectureTime = lecture.LectureTime,
                        LectureType = lecture.LectureType.Type,
                        Subject = lecture.Subject,
                        Group = lecture.Group
                    };

                    mappedLectures.Add(mappedLecture);
                }
            }
                        
            return View(mappedLectures);
        }

        public ActionResult StudentList(int id, DateTime date)
        {
            var lecture = _lectureDataService.GetById(id);
            var group = _groupDataService.GetById(lecture.Group.Id);

            var studentListViewModel = new StudentListViewModel
            {
                LectureId = lecture.Id,
                Auditorium = lecture.Auditorium.Name,
                Lecturer = lecture.Lecturer,
                LectureTime = lecture.LectureTime,
                LectureType = lecture.LectureType.Type,
                Subject = lecture.Subject,
                Group = group,
                Date = date
            };

            return View(studentListViewModel);
        }

        [HttpGet]
        public ActionResult AttendedLectures(int lectureId, DateTime date)
        {
            var lecture = _lectureDataService.GetById(lectureId);
            var group = _groupDataService.GetById(lecture.Group.Id);

            var result = new List<StudentsAttendanceViewModel>();

            foreach(var student in group.Students)
            {
                var attendance = _attendanceDataService.GetStudentAttendance(student.Id, lecture.Id);

                var item = new StudentsAttendanceViewModel
                {
                    StudentId = student.Id,
                    IsAttended = attendance.AttendedLectures.Contains(date.ToString("yyyy-MM-dd"))
                };

                result.Add(item);
            }
            
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateAttendance(UpdateAttendanceViewModel model)
        {
            var attendance = _attendanceDataService.GetStudentAttendance(model.StudentId, model.LectureId);
            var dateString = model.Date.ToString("yyyy-MM-dd");

            attendance.AttendedLectures = attendance.AttendedLectures.Contains(dateString) ?
                attendance.AttendedLectures.Replace(dateString + ",", "") :
                attendance.AttendedLectures + dateString + ",";
            
            _attendanceDataService.UpdateLectures(attendance);

            return Json(attendance);
        }
    }
}