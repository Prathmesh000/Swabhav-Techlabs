using Microsoft.EntityFrameworkCore;
using TimesheetBackend.Models;

namespace TimesheetBackend.Data
{
    public class TimesheetDbContext : DbContext
    {
        public DbSet<Date> Dates { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }

        public TimesheetDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
    }
}
