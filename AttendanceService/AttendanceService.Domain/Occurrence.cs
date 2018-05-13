using System;

namespace AttendanceService.Domain
{
    public class Occurrence
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public bool IsAttended { get; set; }
    }
}
