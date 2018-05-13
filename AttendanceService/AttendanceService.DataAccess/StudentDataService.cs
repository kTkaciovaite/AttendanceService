using AttendanceService.Domain;
using System.Collections.Generic;
using System.Linq;

namespace AttendanceService.DataAccess
{
    public class StudentDataService
    {
        public List<Student> GetAll()
        {
            using (var context = new AttendanceContext())
            {
                return context.Student.ToList();
            }
        }
    }
}
