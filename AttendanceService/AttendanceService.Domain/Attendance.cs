
namespace AttendanceService.Domain
{
    public class Attendance
    {
        public int Id { get; set; }

        public Student Student { get; set; }

        public Lecture Lecture { get; set; }

        public string AttendedLectures { get; set; }
    }
}
