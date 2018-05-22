using AttendanceService.Domain;
using System.Collections.Generic;
using System.Linq;

namespace AttendanceService.DataAccess
{
    public class LectureDataService
    {
        public Lecture GetById(int id)
        {
            using (var context = new AttendanceContext())
            {
                return context.Lecture.Include("Subject").Include("Auditorium").Include("Lecturer").Include("LectureTime")
                    .Include("LectureType").Include("Group").Include("Occurences").FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Lecture> GetByLecturerId(int id)
        {
            using (var context = new AttendanceContext())
            {
                return context.Lecture.Include("Subject").Include("Auditorium").Include("Lecturer").Include("LectureTime")
                    .Include("LectureType").Include("Group").Include("Occurences").Where(x => x.Lecturer.Id == id).ToList();
            }
        }

        public List<Lecture> GetByGroupId(int id)
        {
            using (var context = new AttendanceContext())
            {
                return context.Lecture.Include("Subject").Include("Auditorium").Include("Lecturer").Include("LectureTime")
                    .Include("LectureType").Include("Group").Include("Occurences").Where(x => x.Group.Id == id).ToList();
            }
        }
    }
}
