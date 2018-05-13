using System;

namespace AttendanceService.Domain
{
    public class LectureTime
    {
        public int Id { get; set; }

        public int LectureNumber { get; set; }

        public DateTime LectureStart { get; set; }

        public DateTime LectureEnd { get; set; }
    }
}
