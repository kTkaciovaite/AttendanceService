using AttendanceService.DataAccess;
using AttendanceService.Domain;
using AttendanceService.WebApp.APIControllers.APIModels;
using System;
using System.Web.Http;

namespace AttendanceService.WebApp.APIControllers
{
    public class AttendanceEntryController : ApiController
    {     
        [HttpPost]
        public IHttpActionResult AddEntry(Entry entry)
        {
            // To call this method: 
            // DEV: http://localhost:52051/Api/AttendanceEntry/AddEntry
            // PROD: http://ktkaciovaite-001-site1.ctempurl.com/Api/AttendanceEntry/AddEntry

            var studentDataService = new StudentDataService();
            var students = studentDataService.GetAll();
            
            if (students.Exists(x => x.CardNumber == entry.CardNumber))
            {
                var attendanceEntryDataService = new AttendanceEntryDataService();
                var attendanceEntry = new AttendanceEntry()
                {
                    Time = DateTime.Now,
                    CardNumber = entry.CardNumber,
                    IsAdded = false
                };

                attendanceEntryDataService.Add(attendanceEntry);

                return Ok("Pažymėta");
            }

            return Ok("Kortelės nėra sistemoje");
        }
    }
}
