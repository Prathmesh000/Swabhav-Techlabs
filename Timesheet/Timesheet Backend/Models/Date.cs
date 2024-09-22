namespace TimesheetBackend.Models
{
    public class Date
    {
        public int DateId { get; set; }
        public DateOnly TodaysDate {  get; set; }
        public bool OnLeave { get; set; }
        public List<Timesheet> TimesheetList { get; set; }

    }
}
