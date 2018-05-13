using System.Web.Mvc;

namespace AttendanceService.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }

        //private void _initializeData()
        //{
        //    using (var context = new AttendanceContext())
        //    {
        //        var auditoriums = new List<Auditorium>
        //        {
        //            new Auditorium { Name = "SRA-I 02" },
        //            new Auditorium { Name = "SRA-II 10" },
        //            new Auditorium { Name = "SRL-I 325" },
        //            new Auditorium { Name = "SRL-I 401" },
        //            new Auditorium { Name = "SRL-I 418" },
        //            new Auditorium { Name = "SRL-I 519" },
        //            new Auditorium { Name = "SRL-I 619" }
        //        };
        //        auditoriums.ForEach(x => context.Auditorium.Add(x));

        //        var lectureTimes = new List<LectureTime>
        //        {
        //            new LectureTime { LectureNumber = 1, LectureStart = new DateTime(2000, 1, 1, 8, 30, 0), LectureEnd = new DateTime(2000, 1, 1, 10, 5, 0) },
        //            new LectureTime { LectureNumber = 2, LectureStart = new DateTime(2000, 1, 1, 10, 20, 0), LectureEnd = new DateTime(2000, 1, 1, 11, 55, 0) },
        //            new LectureTime { LectureNumber = 3, LectureStart = new DateTime(2000, 1, 1, 12, 10, 0), LectureEnd = new DateTime(2000, 1, 1, 13, 45, 0) },
        //            new LectureTime { LectureNumber = 4, LectureStart = new DateTime(2000, 1, 1, 14, 30, 0), LectureEnd = new DateTime(2000, 1, 1, 16, 5, 0) },
        //            new LectureTime { LectureNumber = 5, LectureStart = new DateTime(2000, 1, 1, 16, 20, 0), LectureEnd = new DateTime(2000, 1, 1, 17, 55, 0) },
        //            new LectureTime { LectureNumber = 6, LectureStart = new DateTime(2000, 1, 1, 18, 10, 0), LectureEnd = new DateTime(2000, 1, 1, 19, 45, 0) },
        //            new LectureTime { LectureNumber = 7, LectureStart = new DateTime(2000, 1, 1, 19, 55, 0), LectureEnd = new DateTime(2000, 1, 1, 21, 30, 0) }
        //        };
        //        lectureTimes.ForEach(x => context.LectureTime.Add(x));

        //        var lectureTypes = new List<LectureType>
        //        {
        //            new LectureType { Type = "Paskaitos" },
        //            new LectureType { Type = "Pratybos" },
        //            new LectureType { Type = "Laboratoriniai darbai" }
        //        };
        //        lectureTypes.ForEach(x => context.LectureType.Add(x));

        //        var subjects = new List<Subject>
        //        {
        //            new Subject { Code = "FMISB16801", Name = "Duomenų gavybos pagrindai (su kursiniu darbu)" },
        //            new Subject { Code = "FMISB14833", Name = "Informacijos saugos pagrindai" },
        //            new Subject { Code = "FMITB14809", Name = "Programavimas duomenų bazių aplinkoje" },
        //            new Subject { Code = "FMISB14831", Name = "Modernių duomenų bazių pagrindai" }
        //        };
        //        subjects.ForEach(x => context.Subject.Add(x));

        //        var lecturers = new List<Lecturer>
        //        {
        //            new Lecturer { Name = "Vardas1", Surname = "Pavarde1" },
        //            new Lecturer { Name = "Vardas2", Surname = "Pavarde2" },
        //            new Lecturer { Name = "Vardas3", Surname = "Pavarde3" },
        //            new Lecturer { Name = "Vardas4", Surname = "Pavarde4" },
        //            new Lecturer { Name = "Vardas5", Surname = "Pavarde5" },
        //            new Lecturer { Name = "Vardas6", Surname = "Pavarde6" },
        //            new Lecturer { Name = "Vardas7", Surname = "Pavarde7" },
        //            new Lecturer { Name = "Vardas8", Surname = "Pavarde8" }
        //        };
        //        lecturers.ForEach(x => context.Lecturer.Add(x));

        //        var groups = new List<Group>
        //        {
        //            new Group {
        //                Name = "PRIf-14/1", Students = new List<Student>
        //                {
        //                    new Student {
        //                        Name = "Vardas1", Surname = "Pavarde1", CardNumber = "00000000", Lectures = new List<Lecture>
        //                        {
        //                            new Lecture {
        //                                Auditorium = auditoriums[6], Lecturer = lecturers[0], LectureTime = lectureTimes[1],
        //                                LectureType = lectureTypes[2], Subject = subjects[0], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 2) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 9) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 16) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 23) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 30) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[0], Lecturer = lecturers[1], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[0], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 2) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 9) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 16) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 23) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 30) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[1], Lecturer = lecturers[2], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[1], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[3], Lecturer = lecturers[3], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[0], Subject = subjects[3], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[4], Lecturer = lecturers[3], LectureTime = lectureTimes[4],
        //                                LectureType = lectureTypes[2], Subject = subjects[3], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[5], Lecturer = lecturers[4], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[2], Subject = subjects[1], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[0], Lecturer = lecturers[5], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[2], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[2], Lecturer = lecturers[6], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[2], Subject = subjects[2], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                        }
        //                    },
        //                    new Student {
        //                        Name = "Vardas2", Surname = "Pavarde2", CardNumber = "00000001", Lectures = new List<Lecture>
        //                        {
        //                            new Lecture {
        //                                Auditorium = auditoriums[6], Lecturer = lecturers[0], LectureTime = lectureTimes[1],
        //                                LectureType = lectureTypes[2], Subject = subjects[0], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 2) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 9) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 16) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 23) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 30) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[0], Lecturer = lecturers[1], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[0], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 2) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 9) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 16) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 23) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 30) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[1], Lecturer = lecturers[2], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[1], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[3], Lecturer = lecturers[3], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[0], Subject = subjects[3], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[4], Lecturer = lecturers[3], LectureTime = lectureTimes[4],
        //                                LectureType = lectureTypes[2], Subject = subjects[3], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[5], Lecturer = lecturers[4], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[2], Subject = subjects[1], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[0], Lecturer = lecturers[5], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[2], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[2], Lecturer = lecturers[6], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[2], Subject = subjects[2], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                        }
        //                    },
        //                    new Student {
        //                        Name = "Vardas3", Surname = "Pavarde3", CardNumber = "00000002", Lectures = new List<Lecture>
        //                        {
        //                            new Lecture {
        //                                Auditorium = auditoriums[6], Lecturer = lecturers[0], LectureTime = lectureTimes[1],
        //                                LectureType = lectureTypes[2], Subject = subjects[0], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 2) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 9) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 16) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 23) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 30) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[0], Lecturer = lecturers[1], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[0], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 2) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 9) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 16) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 23) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 30) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[1], Lecturer = lecturers[2], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[1], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[3], Lecturer = lecturers[3], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[0], Subject = subjects[3], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[4], Lecturer = lecturers[3], LectureTime = lectureTimes[4],
        //                                LectureType = lectureTypes[2], Subject = subjects[3], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[5], Lecturer = lecturers[4], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[2], Subject = subjects[1], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[0], Lecturer = lecturers[5], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[2], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[2], Lecturer = lecturers[6], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[2], Subject = subjects[2], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                        }
        //                    }
        //                }
        //            },
        //            new Group {
        //                Name = "PRIf-14/2",  Students = new List<Student>
        //                {
        //                    new Student
        //                    {
        //                        Name = "Karolina", Surname = "Tkaciovaite", CardNumber = "EC8C31D5", Lectures = new List<Lecture>
        //                        {
        //                            new Lecture {
        //                                Auditorium = auditoriums[0], Lecturer = lecturers[1], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[0], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 2) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 9) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 16) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 23) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 30) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[6], Lecturer = lecturers[0], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[2], Subject = subjects[0], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 2) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 9) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 16) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 23) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 30) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[1], Lecturer = lecturers[2], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[1], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[3], Lecturer = lecturers[3], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[0], Subject = subjects[3], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 7) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 21) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 4) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 18) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 2) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[4], Lecturer = lecturers[3], LectureTime = lectureTimes[4],
        //                                LectureType = lectureTypes[2], Subject = subjects[3], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 14) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 28) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 11) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 25) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[4], Lecturer = lecturers[7], LectureTime = lectureTimes[1],
        //                                LectureType = lectureTypes[2], Subject = subjects[1], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[0], Lecturer = lecturers[5], LectureTime = lectureTimes[2],
        //                                LectureType = lectureTypes[0], Subject = subjects[2], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 8) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 22) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 5) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 19) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 5, 3) }
        //                                }
        //                            },
        //                            new Lecture {
        //                                Auditorium = auditoriums[2], Lecturer = lecturers[6], LectureTime = lectureTimes[3],
        //                                LectureType = lectureTypes[2], Subject = subjects[2], Occurrences = new List<Occurrence>
        //                                {
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 2, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 1) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 15) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 3, 29) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 12) },
        //                                    new Occurrence { IsAttended = false, Date = new DateTime(2018, 4, 26) }
        //                                }
        //                            },
        //                        }
        //                    }
        //                }
        //            }
        //        };
        //        groups.ForEach(x => context.Group.Add(x));

        //        context.SaveChanges();
        //    }
        //}
    }
}