using Microsoft.EntityFrameworkCore;
using TimesheetBackend.Data;
using TimesheetBackend.Models;

namespace TimesheetBackend.Repository
{
    public class TimesheetRepository : ITimesheetRepository
    {
        private readonly TimesheetDbContext _context;

        public TimesheetRepository(TimesheetDbContext context)
        {
            _context = context;
        }


        public void UpdateTimesheet(Timesheet timesheet)
        {
            var updateTimesheet = _context.Timesheets.FirstOrDefault(x => x.TimesheetId == timesheet.TimesheetId);
            updateTimesheet.Project = timesheet.Project;
            updateTimesheet.SubProject = timesheet.SubProject;
            updateTimesheet.Batch = timesheet.Batch;
            updateTimesheet.HoursNeeded = timesheet.HoursNeeded;
            updateTimesheet.Activity = timesheet.Activity;
            _context.SaveChanges();
        }
        public void DeleteTimesheet(int id)
        {
            var timesheet = _context.Timesheets.FirstOrDefault(t => t.TimesheetId == id);
            _context.Timesheets.Remove(timesheet);
            _context.SaveChanges();
        }
    }
}
