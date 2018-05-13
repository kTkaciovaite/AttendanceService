using AttendanceService.Domain;

namespace AttendanceService.DataAccess
{
    public class AttendanceEntryDataService
    {
        public void Add(AttendanceEntry attendanceEntry)
        {
            using (var context = new AttendanceContext())
            {
                context.AttendanceEntry.Add(attendanceEntry);
                context.SaveChanges();
            }
        }
    }
}
