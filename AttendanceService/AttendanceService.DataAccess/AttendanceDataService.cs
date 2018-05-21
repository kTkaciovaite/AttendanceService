using AttendanceService.Domain;
using System.Data.Entity.Migrations;
using System.Linq;

namespace AttendanceService.DataAccess
{
    public class AttendanceDataService
    {
        public Attendance GetStudentAttendance(int studentId, int lectureId)
        {
            using (var context = new AttendanceContext())
            {
                return context.Attendance.Include("Student").Include("Lecture")
                    .FirstOrDefault(x => x.Student.Id == studentId && x.Lecture.Id == lectureId);
            }
        }

        public void UpdateLectures(Attendance attendance)
        {
            using (var context = new AttendanceContext())
            {
                if (context.Attendance.FirstOrDefault(x => x.Id == attendance.Id) != null)
                {
                    context.Attendance.FirstOrDefault(x => x.Id == attendance.Id).AttendedLectures = attendance.AttendedLectures;
                    context.SaveChanges();
                }
            }
        }
    }
}
