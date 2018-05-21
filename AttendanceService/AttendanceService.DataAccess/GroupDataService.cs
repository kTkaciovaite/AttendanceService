using AttendanceService.Domain;
using System.Collections.Generic;
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
    }
}
