using AttendanceService.DataAccess;
using AttendanceService.Domain;
using AttendanceService.WebApp.APIControllers.APIModels;
using System;
using System.Linq;
using System.Threading;
using System.Web.Http;

namespace AttendanceService.WebApp.APIControllers
{
    public class AttendanceEntryController : ApiController
    {     
        [HttpPost]
        public IHttpActionResult AddEntry(Entry entry)
        {
            // To call this method: 
            // DEV: http://localhost:52051/Api/AttendanceEntry/AddEntry
            // PROD: http://ktkaciovaite-001-site1.ctempurl.com/Api/AttendanceEntry/AddEntry

            var studentDataService = new StudentDataService();
            var students = studentDataService.GetAll();
            
            if (students.Exists(x => x.CardNumber == entry.CardNumber))
            {
                var attendanceEntryDataService = new AttendanceEntryDataService();
                var attendanceEntry = new AttendanceEntry()
                {
                    Time = DateTime.Now,
                    CardNumber = entry.CardNumber
                };

                attendanceEntryDataService.Add(attendanceEntry);

                var updateAttendanceThread = new Thread(() => UpdateAttendance(attendanceEntry.Time, attendanceEntry.CardNumber));
                updateAttendanceThread.Start();
                
                return Ok("Pažymėta");
            }

            return Ok("Kortelės nėra sistemoje");
        }

        private void UpdateAttendance(DateTime date, string cardNumber)
        {
            var currentTime = new DateTime(2018, 4, 16, 14, 27, 52);

            var studentDataService = new StudentDataService();
            var student = studentDataService.GetByCardNumber(cardNumber);

            var groupDataService = new GroupDataService();
            var group = groupDataService.GetByStudent(student.Id);

            var lectureDataService = new LectureDataService();
            var lectures = lectureDataService.GetByGroupId(group.Id);

            var lectureId = -1;
            foreach (var lecture in lectures)
            {
                if (lecture.Occurences.FirstOrDefault(x => x.Date.ToShortDateString() == currentTime.ToShortDateString()) != null
                    && lecture.LectureTime.LectureStart.AddMinutes(-5).TimeOfDay <= currentTime.TimeOfDay
                    && lecture.LectureTime.LectureEnd.AddMinutes(5).TimeOfDay >= currentTime.TimeOfDay)
                {
                    lectureId = lecture.Id;
                    break;
                }
            }

            if (lectureId != -1)
            {
                var attendanceDataService = new AttendanceDataService();
                var attendance = attendanceDataService.GetStudentAttendance(student.Id, lectureId);
                var dateString = currentTime.ToString("yyyy-MM-dd");

                if (!attendance.AttendedLectures.Contains(dateString))
                {
                    attendance.AttendedLectures += dateString + ",";
                }
                
                attendanceDataService.UpdateLectures(attendance);
            }
        }
    }
}
