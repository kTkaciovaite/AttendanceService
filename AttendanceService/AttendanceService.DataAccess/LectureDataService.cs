using AttendanceService.Domain;
using System.Collections.Generic;
using System.Linq;

namespace AttendanceService.DataAccess
{
    public class LectureDataService
    {
        public List<Lecture> GetByLecturerId(int id)
        {
            using (var context = new AttendanceContext())
            {
                return context.Lecture.Include("Subject")
                    .Where(x => x.Lecturer.Id == id).ToList();
            }
        }
    }
}
