using Microsoft.EntityFrameworkCore;
using TimesheetBackend.Data;
using TimesheetBackend.Models;

namespace TimesheetBackend.Repository
{
    public class DateRepository : IDateRepository
    {
        private readonly TimesheetDbContext _dbContext;

        public DateRepository(TimesheetDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Date> Get()
        {
           return _dbContext.Dates.Include(d => d.TimesheetList).ToList();
        }

        public void Post(Date date)
        {
           _dbContext.Dates.Add(date);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var date = _dbContext.Dates.Include(d => d.TimesheetList).FirstOrDefault(d => d.DateId == id);
            
                _dbContext.Timesheets.RemoveRange(date.TimesheetList);
                _dbContext.Dates.Remove(date);
                _dbContext.SaveChanges();
        }
    }
}
