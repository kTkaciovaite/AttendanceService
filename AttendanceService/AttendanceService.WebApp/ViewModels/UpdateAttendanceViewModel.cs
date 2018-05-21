using System;

namespace AttendanceService.WebApp.ViewModels
{
    public class UpdateAttendanceViewModel
    {
        public int LectureId { get; set; }

        public int StudentId { get; set; }

        public DateTime Date { get; set; }
    }
}