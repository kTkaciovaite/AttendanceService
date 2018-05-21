using AttendanceService.Domain;
using System;

namespace AttendanceService.WebApp.ViewModels
{
    public class StudentListViewModel
    {
        public int LectureId { get; set; }

        public string Auditorium { get; set; }

        public Lecturer Lecturer { get; set; }

        public LectureTime LectureTime { get; set; }

        public string LectureType { get; set; }

        public Subject Subject { get; set; }

        public Group Group { get; set; }

        public DateTime Date { get; set; }
    }
}