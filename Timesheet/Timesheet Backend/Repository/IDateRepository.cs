using TimesheetBackend.Models;

namespace TimesheetBackend.Repository
{
    public interface IDateRepository
    {
        IEnumerable<Date> Get();
        void Post(Date date);
        void Delete(int id);

    }
}
