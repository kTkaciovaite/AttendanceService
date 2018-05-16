using AttendanceService.Domain;
using System.Linq;

namespace AttendanceService.DataAccess
{
    public class LecturerDataService
    {
        public Lecturer GetByUserId(string id)
        {
            using (var context = new AttendanceContext())
            {
                return context.Lecturer.FirstOrDefault(x => x.UserId == id);
            }
        }
    }
}
