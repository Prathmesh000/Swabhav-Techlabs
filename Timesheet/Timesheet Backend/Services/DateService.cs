using TimesheetBackend.Models;
using TimesheetBackend.Repository;

namespace TimesheetBackend.Services
{
    public class DateService : IDateService
    {
        private readonly IDateRepository _dateRepository;

        public DateService(IDateRepository dateRepository)
        {
            _dateRepository = dateRepository;
        }
        public IEnumerable<Date> GetDateService()
        {
            return _dateRepository.Get();   
        }

        public void PostDateService(Date date)
        {
            _dateRepository.Post(date);
        }

        public void DeleteDateService(int id)
        {
            _dateRepository.Delete(id);
        }
    }
}
