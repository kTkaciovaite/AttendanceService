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

        public Student GetById(int id)
        {
            using (var context = new AttendanceContext())
            {
                return context.Student.FirstOrDefault(x => x.Id == id);
            }
        }

        public Student GetByCardNumber(string cardNumber)
        {
            using (var context = new AttendanceContext())
            {
                return context.Student.FirstOrDefault(x => x.CardNumber == cardNumber);
            }
        }
    }
}
