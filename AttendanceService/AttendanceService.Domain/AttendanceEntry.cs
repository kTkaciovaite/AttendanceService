using System;

namespace AttendanceService.Domain
{
    public class AttendanceEntry
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string CardNumber { get; set; }

        public bool IsAdded { get; set; }
    }
}
