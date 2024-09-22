using TimesheetBackend.Models;

namespace TimesheetBackend.Services
{
    public interface IDateService
    {
        IEnumerable<Date> GetDateService();
        void PostDateService(Date date);
        void DeleteDateService(int id);
    }
}
