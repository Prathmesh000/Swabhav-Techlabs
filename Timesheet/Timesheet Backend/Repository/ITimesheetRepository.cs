using TimesheetBackend.Models;

namespace TimesheetBackend.Repository
{
    public interface ITimesheetRepository
    {
        void UpdateTimesheet(Timesheet timesheet);
        void DeleteTimesheet(int id);
    }
}
