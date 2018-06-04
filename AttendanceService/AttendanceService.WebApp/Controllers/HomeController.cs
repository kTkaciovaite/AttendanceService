using AttendanceService.DataAccess;
using AttendanceService.Domain;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AttendanceService.WebApp.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        private void _initializeData()
        {
            using (var context = new AttendanceContext())
            {
                var auditoriums = new List<Auditorium>
                {
                    new Auditorium { Name = "SRA-I 02" },
                    new Auditorium { Name = "SRA-II 10" },
                    new Auditorium { Name = "SRL-I 325" },
                    new Auditorium { Name = "SRL-I 401" },
                    new Auditorium { Name = "SRL-I 418" },
                    new Auditorium { Name = "SRL-I 519" },
                    new Auditorium { Name = "SRL-I 619" }
                };
                auditoriums.ForEach(x => context.Auditorium.Add(x));
                context.SaveChanges();

                var lectureTimes = new List<LectureTime>
                {
                    new LectureTime { LectureNumber = 1, LectureStart = new DateTime(2000, 1, 1, 8, 30, 0), LectureEnd = new DateTime(2000, 1, 1, 10, 5, 0) },
                    new LectureTime { LectureNumber = 2, LectureStart = new DateTime(2000, 1, 1, 10, 20, 0), LectureEnd = new DateTime(2000, 1, 1, 11, 55, 0) },
                    new LectureTime { LectureNumber = 3, LectureStart = new DateTime(2000, 1, 1, 12, 10, 0), LectureEnd = new DateTime(2000, 1, 1, 13, 45, 0) },
                    new LectureTime { LectureNumber = 4, LectureStart = new DateTime(2000, 1, 1, 14, 30, 0), LectureEnd = new DateTime(2000, 1, 1, 16, 5, 0) },
                    new LectureTime { LectureNumber = 5, LectureStart = new DateTime(2000, 1, 1, 16, 20, 0), LectureEnd = new DateTime(2000, 1, 1, 17, 55, 0) },
                    new LectureTime { LectureNumber = 6, LectureStart = new DateTime(2000, 1, 1, 18, 10, 0), LectureEnd = new DateTime(2000, 1, 1, 19, 45, 0) },
                    new LectureTime { LectureNumber = 7, LectureStart = new DateTime(2000, 1, 1, 19, 55, 0), LectureEnd = new DateTime(2000, 1, 1, 21, 30, 0) }
                };
                lectureTimes.ForEach(x => context.LectureTime.Add(x));
                context.SaveChanges();

                var lectureTypes = new List<LectureType>
                {
                    new LectureType { Type = "Paskaitos" },
                    new LectureType { Type = "Pratybos" },
                    new LectureType { Type = "Laboratoriniai darbai" }
                };
                lectureTypes.ForEach(x => context.LectureType.Add(x));
                context.SaveChanges();

                var subjects = new List<Subject>
                {
                    new Subject { Code = "FMISB16801", Name = "Duomenų gavybos pagrindai (su kursiniu darbu)" },
                    new Subject { Code = "FMISB14833", Name = "Informacijos saugos pagrindai" },
                    new Subject { Code = "FMITB14809", Name = "Programavimas duomenų bazių aplinkoje" },
                    new Subject { Code = "FMISB14831", Name = "Modernių duomenų bazių pagrindai" }
                };
                subjects.ForEach(x => context.Subject.Add(x));
                context.SaveChanges();

                var lecturers = new List<Lecturer>
                {
                    new Lecturer { Name = "Vardas1", Surname = "Pavarde1" },
                    new Lecturer { Name = "Vardas2", Surname = "Pavarde2" },
                    new Lecturer { Name = "Vardas3", Surname = "Pavarde3" },
                    new Lecturer { Name = "Vardas4", Surname = "Pavarde4" },
                    new Lecturer { Name = "Vardas5", Surname = "Pavarde5" },
                    new Lecturer { Name = "Vardas6", Surname = "Pavarde6" },
                    new Lecturer { Name = "Vardas7", Surname = "Pavarde7" },
                    new Lecturer { Name = "Vardas8", Surname = "Pavarde8" }
                };
                lecturers.ForEach(x => context.Lecturer.Add(x));
                context.SaveChanges();

                var prif1Students = new List<Student>
                {
                    new Student { Name = "Vardas1", Surname = "Pavarde1", CardNumber = "00000000", StudentId = "20140000" },
                    new Student { Name = "Vardas2", Surname = "Pavarde2", CardNumber = "00000001", StudentId = "20140001" },
                    new Student { Name = "Vardas3", Surname = "Pavarde3", CardNumber = "00000002", StudentId = "20140002" }
                };
                prif1Students.ForEach(x => context.Student.Add(x));
                context.SaveChanges();

                var prif2Students = new List<Student>
                {
                    new Student { Name = "Karolina", Surname = "Tkaciovaite", CardNumber = "EC8C31D5", StudentId = "20145066" },
                    new Student { Name = "Vardas4", Surname = "Pavarde4", CardNumber = "00000003", StudentId = "20140003" },
                    new Student { Name = "Vardas5", Surname = "Pavarde5", CardNumber = "00000004", StudentId = "20140004" }
                };
                prif2Students.ForEach(x => context.Student.Add(x));
                context.SaveChanges();

                var groups = new List<Group>
                {
                    new Group { Name = "PRIf-14/1", Students = prif1Students },
                    new Group { Name = "PRIf-14/2", Students = prif2Students }
                };
                groups.ForEach(x => context.Group.Add(x));
                context.SaveChanges();

                var lectures = new List<Lecture>
                {
                    new Lecture
                    {
                        Auditorium = auditoriums[6], Lecturer = lecturers[0], LectureTime = lectureTimes[1],
                        LectureType = lectureTypes[2], Subject = subjects[0], Group = groups[0],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 5) }, new Occurence { Date = new DateTime(2018, 2, 12) },
                            new Occurence { Date = new DateTime(2018, 2, 19) }, new Occurence { Date = new DateTime(2018, 2, 26) },
                            new Occurence { Date = new DateTime(2018, 3, 5) }, new Occurence { Date = new DateTime(2018, 3, 12) },
                            new Occurence { Date = new DateTime(2018, 3, 19) }, new Occurence { Date = new DateTime(2018, 3, 26) },
                            new Occurence { Date = new DateTime(2018, 4, 2) }, new Occurence { Date = new DateTime(2018, 4, 9) },
                            new Occurence { Date = new DateTime(2018, 4, 16) }, new Occurence { Date = new DateTime(2018, 4, 23) },
                            new Occurence { Date = new DateTime(2018, 4, 30) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[0], Lecturer = lecturers[1], LectureTime = lectureTimes[2],
                        LectureType = lectureTypes[0], Subject = subjects[0], Group = groups[0],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 5) }, new Occurence { Date = new DateTime(2018, 2, 12) },
                            new Occurence { Date = new DateTime(2018, 2, 19) }, new Occurence { Date = new DateTime(2018, 2, 26) },
                            new Occurence { Date = new DateTime(2018, 3, 5) }, new Occurence { Date = new DateTime(2018, 3, 12) },
                            new Occurence { Date = new DateTime(2018, 3, 19) }, new Occurence { Date = new DateTime(2018, 3, 26) },
                            new Occurence { Date = new DateTime(2018, 4, 2) }, new Occurence { Date = new DateTime(2018, 4, 9) },
                            new Occurence { Date = new DateTime(2018, 4, 16) }, new Occurence { Date = new DateTime(2018, 4, 23) },
                            new Occurence { Date = new DateTime(2018, 4, 30) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[0], Lecturer = lecturers[1], LectureTime = lectureTimes[2],
                        LectureType = lectureTypes[0], Subject = subjects[0], Group = groups[1],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 5) }, new Occurence { Date = new DateTime(2018, 2, 12) },
                            new Occurence { Date = new DateTime(2018, 2, 19) }, new Occurence { Date = new DateTime(2018, 2, 26) },
                            new Occurence { Date = new DateTime(2018, 3, 5) }, new Occurence { Date = new DateTime(2018, 3, 12) },
                            new Occurence { Date = new DateTime(2018, 3, 19) }, new Occurence { Date = new DateTime(2018, 3, 26) },
                            new Occurence { Date = new DateTime(2018, 4, 2) }, new Occurence { Date = new DateTime(2018, 4, 9) },
                            new Occurence { Date = new DateTime(2018, 4, 16) }, new Occurence { Date = new DateTime(2018, 4, 23) },
                            new Occurence { Date = new DateTime(2018, 4, 30) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[6], Lecturer = lecturers[0], LectureTime = lectureTimes[3],
                        LectureType = lectureTypes[2], Subject = subjects[0], Group = groups[1],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 5) }, new Occurence { Date = new DateTime(2018, 2, 12) },
                            new Occurence { Date = new DateTime(2018, 2, 19) }, new Occurence { Date = new DateTime(2018, 2, 26) },
                            new Occurence { Date = new DateTime(2018, 3, 5) }, new Occurence { Date = new DateTime(2018, 3, 12) },
                            new Occurence { Date = new DateTime(2018, 3, 19) }, new Occurence { Date = new DateTime(2018, 3, 26) },
                            new Occurence { Date = new DateTime(2018, 4, 2) }, new Occurence { Date = new DateTime(2018, 4, 9) },
                            new Occurence { Date = new DateTime(2018, 4, 16) }, new Occurence { Date = new DateTime(2018, 4, 23) },
                            new Occurence { Date = new DateTime(2018, 4, 30) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[1], Lecturer = lecturers[2], LectureTime = lectureTimes[2],
                        LectureType = lectureTypes[0], Subject = subjects[1], Group = groups[0],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 7) }, new Occurence { Date = new DateTime(2018, 2, 14) },
                            new Occurence { Date = new DateTime(2018, 2, 21) }, new Occurence { Date = new DateTime(2018, 2, 28) },
                            new Occurence { Date = new DateTime(2018, 3, 7) }, new Occurence { Date = new DateTime(2018, 3, 14) },
                            new Occurence { Date = new DateTime(2018, 3, 21) }, new Occurence { Date = new DateTime(2018, 3, 28) },
                            new Occurence { Date = new DateTime(2018, 4, 4) }, new Occurence { Date = new DateTime(2018, 4, 11) },
                            new Occurence { Date = new DateTime(2018, 4, 18) }, new Occurence { Date = new DateTime(2018, 4, 25) },
                            new Occurence { Date = new DateTime(2018, 5, 2) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[1], Lecturer = lecturers[2], LectureTime = lectureTimes[2],
                        LectureType = lectureTypes[0], Subject = subjects[1], Group = groups[1],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 7) }, new Occurence { Date = new DateTime(2018, 2, 14) },
                            new Occurence { Date = new DateTime(2018, 2, 21) }, new Occurence { Date = new DateTime(2018, 2, 28) },
                            new Occurence { Date = new DateTime(2018, 3, 7) }, new Occurence { Date = new DateTime(2018, 3, 14) },
                            new Occurence { Date = new DateTime(2018, 3, 21) }, new Occurence { Date = new DateTime(2018, 3, 28) },
                            new Occurence { Date = new DateTime(2018, 4, 4) }, new Occurence { Date = new DateTime(2018, 4, 11) },
                            new Occurence { Date = new DateTime(2018, 4, 18) }, new Occurence { Date = new DateTime(2018, 4, 25) },
                            new Occurence { Date = new DateTime(2018, 5, 2) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[3], Lecturer = lecturers[3], LectureTime = lectureTimes[3],
                        LectureType = lectureTypes[0], Subject = subjects[3], Group = groups[0],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 7) }, new Occurence { Date = new DateTime(2018, 2, 14) },
                            new Occurence { Date = new DateTime(2018, 2, 21) }, new Occurence { Date = new DateTime(2018, 2, 28) },
                            new Occurence { Date = new DateTime(2018, 3, 7) }, new Occurence { Date = new DateTime(2018, 3, 14) },
                            new Occurence { Date = new DateTime(2018, 3, 21) }, new Occurence { Date = new DateTime(2018, 3, 28) },
                            new Occurence { Date = new DateTime(2018, 4, 4) }, new Occurence { Date = new DateTime(2018, 4, 11) },
                            new Occurence { Date = new DateTime(2018, 4, 18) }, new Occurence { Date = new DateTime(2018, 4, 25) },
                            new Occurence { Date = new DateTime(2018, 5, 2) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[3], Lecturer = lecturers[3], LectureTime = lectureTimes[3],
                        LectureType = lectureTypes[0], Subject = subjects[3], Group = groups[1],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 7) }, new Occurence { Date = new DateTime(2018, 2, 14) },
                            new Occurence { Date = new DateTime(2018, 2, 21) }, new Occurence { Date = new DateTime(2018, 2, 28) },
                            new Occurence { Date = new DateTime(2018, 3, 7) }, new Occurence { Date = new DateTime(2018, 3, 14) },
                            new Occurence { Date = new DateTime(2018, 3, 21) }, new Occurence { Date = new DateTime(2018, 3, 28) },
                            new Occurence { Date = new DateTime(2018, 4, 4) }, new Occurence { Date = new DateTime(2018, 4, 11) },
                            new Occurence { Date = new DateTime(2018, 4, 18) }, new Occurence { Date = new DateTime(2018, 4, 25) },
                            new Occurence { Date = new DateTime(2018, 5, 2) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[4], Lecturer = lecturers[3], LectureTime = lectureTimes[4],
                        LectureType = lectureTypes[2], Subject = subjects[3], Group = groups[0],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 7) }, new Occurence { Date = new DateTime(2018, 2, 21) },
                            new Occurence { Date = new DateTime(2018, 3, 7) }, new Occurence { Date = new DateTime(2018, 3, 21) },
                            new Occurence { Date = new DateTime(2018, 4, 4) }, new Occurence { Date = new DateTime(2018, 4, 18) },
                            new Occurence { Date = new DateTime(2018, 5, 2) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[4], Lecturer = lecturers[3], LectureTime = lectureTimes[4],
                        LectureType = lectureTypes[2], Subject = subjects[3], Group = groups[1],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 14) }, new Occurence { Date = new DateTime(2018, 2, 28) },
                            new Occurence { Date = new DateTime(2018, 3, 14) }, new Occurence { Date = new DateTime(2018, 3, 28) },
                            new Occurence { Date = new DateTime(2018, 4, 11) }, new Occurence { Date = new DateTime(2018, 4, 25) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[5], Lecturer = lecturers[4], LectureTime = lectureTimes[1],
                        LectureType = lectureTypes[2], Subject = subjects[1], Group = groups[0],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 8) }, new Occurence { Date = new DateTime(2018, 2, 15) },
                            new Occurence { Date = new DateTime(2018, 2, 22) }, new Occurence { Date = new DateTime(2018, 3, 1) },
                            new Occurence { Date = new DateTime(2018, 3, 8) }, new Occurence { Date = new DateTime(2018, 3, 15) },
                            new Occurence { Date = new DateTime(2018, 3, 22) }, new Occurence { Date = new DateTime(2018, 3, 29) },
                            new Occurence { Date = new DateTime(2018, 4, 5) }, new Occurence { Date = new DateTime(2018, 4, 12) },
                            new Occurence { Date = new DateTime(2018, 4, 19) }, new Occurence { Date = new DateTime(2018, 4, 26) },
                            new Occurence { Date = new DateTime(2018, 5, 3) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[4], Lecturer = lecturers[7], LectureTime = lectureTimes[1],
                        LectureType = lectureTypes[2], Subject = subjects[1], Group = groups[1],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 8) }, new Occurence { Date = new DateTime(2018, 2, 15) },
                            new Occurence { Date = new DateTime(2018, 2, 22) }, new Occurence { Date = new DateTime(2018, 3, 1) },
                            new Occurence { Date = new DateTime(2018, 3, 8) }, new Occurence { Date = new DateTime(2018, 3, 15) },
                            new Occurence { Date = new DateTime(2018, 3, 22) }, new Occurence { Date = new DateTime(2018, 3, 29) },
                            new Occurence { Date = new DateTime(2018, 4, 5) }, new Occurence { Date = new DateTime(2018, 4, 12) },
                            new Occurence { Date = new DateTime(2018, 4, 19) }, new Occurence { Date = new DateTime(2018, 4, 26) },
                            new Occurence { Date = new DateTime(2018, 5, 3) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[0], Lecturer = lecturers[5], LectureTime = lectureTimes[2],
                        LectureType = lectureTypes[0], Subject = subjects[2], Group = groups[0],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 8) }, new Occurence { Date = new DateTime(2018, 2, 15) },
                            new Occurence { Date = new DateTime(2018, 2, 22) }, new Occurence { Date = new DateTime(2018, 3, 1) },
                            new Occurence { Date = new DateTime(2018, 3, 8) }, new Occurence { Date = new DateTime(2018, 3, 15) },
                            new Occurence { Date = new DateTime(2018, 3, 22) }, new Occurence { Date = new DateTime(2018, 3, 29) },
                            new Occurence { Date = new DateTime(2018, 4, 5) }, new Occurence { Date = new DateTime(2018, 4, 12) },
                            new Occurence { Date = new DateTime(2018, 4, 19) }, new Occurence { Date = new DateTime(2018, 4, 26) },
                            new Occurence { Date = new DateTime(2018, 5, 3) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[0], Lecturer = lecturers[5], LectureTime = lectureTimes[2],
                        LectureType = lectureTypes[0], Subject = subjects[2], Group = groups[1],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 8) }, new Occurence { Date = new DateTime(2018, 2, 15) },
                            new Occurence { Date = new DateTime(2018, 2, 22) }, new Occurence { Date = new DateTime(2018, 3, 1) },
                            new Occurence { Date = new DateTime(2018, 3, 8) }, new Occurence { Date = new DateTime(2018, 3, 15) },
                            new Occurence { Date = new DateTime(2018, 3, 22) }, new Occurence { Date = new DateTime(2018, 3, 29) },
                            new Occurence { Date = new DateTime(2018, 4, 5) }, new Occurence { Date = new DateTime(2018, 4, 12) },
                            new Occurence { Date = new DateTime(2018, 4, 19) }, new Occurence { Date = new DateTime(2018, 4, 26) },
                            new Occurence { Date = new DateTime(2018, 5, 3) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[2], Lecturer = lecturers[6], LectureTime = lectureTimes[3],
                        LectureType = lectureTypes[2], Subject = subjects[2], Group = groups[0],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 8) }, new Occurence { Date = new DateTime(2018, 2, 22) },
                            new Occurence { Date = new DateTime(2018, 3, 8) }, new Occurence { Date = new DateTime(2018, 3, 22) },
                            new Occurence { Date = new DateTime(2018, 4, 5) }, new Occurence { Date = new DateTime(2018, 4, 19) },
                            new Occurence { Date = new DateTime(2018, 5, 3) }
                        }
                    },
                    new Lecture
                    {
                        Auditorium = auditoriums[2], Lecturer = lecturers[6], LectureTime = lectureTimes[3],
                        LectureType = lectureTypes[2], Subject = subjects[2], Group = groups[1],
                        Occurences = new List<Occurence>
                        {
                            new Occurence { Date = new DateTime(2018, 2, 15) }, new Occurence { Date = new DateTime(2018, 3, 1) },
                            new Occurence { Date = new DateTime(2018, 3, 15) }, new Occurence { Date = new DateTime(2018, 3, 29) },
                            new Occurence { Date = new DateTime(2018, 4, 12) }, new Occurence { Date = new DateTime(2018, 4, 26) }
                        }
                    }
                };
                lectures.ForEach(x => context.Lecture.Add(x));
                context.SaveChanges();

                var attendances = new List<Attendance>
                {
                    new Attendance { Student = prif1Students[0], Lecture = lectures[0], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[0], Lecture = lectures[1], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[0], Lecture = lectures[4], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[0], Lecture = lectures[6], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[0], Lecture = lectures[8], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[0], Lecture = lectures[10], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[0], Lecture = lectures[12], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[0], Lecture = lectures[14], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[1], Lecture = lectures[0], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[1], Lecture = lectures[1], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[1], Lecture = lectures[4], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[1], Lecture = lectures[6], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[1], Lecture = lectures[8], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[1], Lecture = lectures[10], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[1], Lecture = lectures[12], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[1], Lecture = lectures[14], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[2], Lecture = lectures[0], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[2], Lecture = lectures[1], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[2], Lecture = lectures[4], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[2], Lecture = lectures[6], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[2], Lecture = lectures[8], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[2], Lecture = lectures[10], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[2], Lecture = lectures[12], AttendedLectures = "" },
                    new Attendance { Student = prif1Students[2], Lecture = lectures[14], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[0], Lecture = lectures[2], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[0], Lecture = lectures[3], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[0], Lecture = lectures[5], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[0], Lecture = lectures[7], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[0], Lecture = lectures[9], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[0], Lecture = lectures[11], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[0], Lecture = lectures[13], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[0], Lecture = lectures[15], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[1], Lecture = lectures[2], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[1], Lecture = lectures[3], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[1], Lecture = lectures[5], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[1], Lecture = lectures[7], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[1], Lecture = lectures[9], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[1], Lecture = lectures[11], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[1], Lecture = lectures[13], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[1], Lecture = lectures[15], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[2], Lecture = lectures[2], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[2], Lecture = lectures[3], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[2], Lecture = lectures[5], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[2], Lecture = lectures[7], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[2], Lecture = lectures[9], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[2], Lecture = lectures[11], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[2], Lecture = lectures[13], AttendedLectures = "" },
                    new Attendance { Student = prif2Students[2], Lecture = lectures[15], AttendedLectures = "" }
                };
                attendances.ForEach(x => context.Attendance.Add(x));
                context.SaveChanges();
            }
        }
    }
}