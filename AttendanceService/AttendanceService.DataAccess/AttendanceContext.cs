using AttendanceService.Domain;
using System.Data.Entity;

namespace AttendanceService.DataAccess
{
    public class AttendanceContext : DbContext
    {
        public DbSet<Attendance> Attendance { get; set; }

        public DbSet<AttendanceEntry> AttendanceEntry { get; set; }

        public DbSet<Auditorium> Auditorium { get; set; }

        public DbSet<Group> Group { get; set; }

        public DbSet<Lecture> Lecture { get; set; }

        public DbSet<Lecturer> Lecturer { get; set; }

        public DbSet<LectureTime> LectureTime { get; set; }

        public DbSet<LectureType> LectureType { get; set; }

        public DbSet<Occurence> Occurence { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Subject> Subject { get; set; }
    }
}
