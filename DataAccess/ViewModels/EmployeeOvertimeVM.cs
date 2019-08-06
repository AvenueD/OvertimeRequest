using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeOvertimeVM
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Activity { get; set; }
        public int Employee { get; set; }
        public int OvertimeRequest { get; set; }

        public EmployeeOvertimeVM() { }

        public EmployeeOvertimeVM(TimeSpan starttime, TimeSpan endtime, string activity)
        {
            this.StartTime = starttime;
            this.EndTime = endtime;
            this.Activity = activity;
        }

        public void Update(TimeSpan starttime, TimeSpan endtime, string activity)
        {
            this.StartTime = starttime;
            this.EndTime = endtime;
            this.Activity = activity;
        }
    }
}
