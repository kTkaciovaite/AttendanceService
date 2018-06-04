
namespace AttendanceService.WebApp.ViewModels
{
    public class ReportSubjectAttendance
    {
        public string StudentNumber { get; set; }

        public string Student { get; set; }

        public string Group { get; set; }

        public int AttendedLecturesCount { get; set; }

        public int LecturesCount { get; set; }
    }
}