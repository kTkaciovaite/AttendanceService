using AttendanceService.Domain;
using System.Linq;

namespace AttendanceService.DataAccess
{
    public class GroupDataService
    {
        public Group GetById(int id)
        {
            using (var context = new AttendanceContext())
            {
                return context.Group.Include("Students").FirstOrDefault(x => x.Id == id);
            }
        }

        public Group GetByStudent(int studentId)
        {
            using (var context = new AttendanceContext())
            {
                return context.Group.FirstOrDefault(x => x.Students.FirstOrDefault(y => y.Id == studentId) != null);
            }
        }
    }
}
