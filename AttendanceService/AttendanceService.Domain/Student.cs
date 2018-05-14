using System.Collections.Generic;

namespace AttendanceService.Domain
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string CardNumber { get; set; }

        public List<Lecture> Lectures { get; set; }

        public string UserId { get; set; }
    }
}
