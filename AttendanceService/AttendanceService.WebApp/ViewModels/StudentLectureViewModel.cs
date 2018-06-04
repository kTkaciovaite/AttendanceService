using AttendanceService.Domain;
using System;

namespace AttendanceService.WebApp.ViewModels
{
    public class StudentLectureViewModel
    {
        public int Id { get; set; }

        public string Auditorium { get; set; }

        public string Lecturer { get; set; }

        public DateTime Date { get; set; }

        public LectureTime LectureTime { get; set; }

        public string LectureType { get; set; }

        public Subject Subject { get; set; }

        public Group Group { get; set; }

        public bool IsAttended { get; set; }
    }
}