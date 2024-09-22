namespace TimesheetBackend.Models
{
    public class Timesheet
    {
        public int TimesheetId { get; set; }
        public string Project { get; set; }
        public string SubProject { get; set; }
        public string Batch { get; set; }
        public int HoursNeeded {  get; set; }
        public string Activity {  get; set; }
    }
}
