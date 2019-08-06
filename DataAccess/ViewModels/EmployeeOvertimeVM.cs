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
        public int EmployeeId { get; set; }
        public int OvertimeRequestId { get; set; }

        public EmployeeOvertimeVM() { }

        public EmployeeOvertimeVM(TimeSpan starttime, TimeSpan endtime, string activity, int employeeid, int overtimerequestid)
        {
            this.StartTime = starttime;
            this.EndTime = endtime;
            this.Activity = activity;
            this.EmployeeId = employeeid;
            this.OvertimeRequestId = overtimerequestid;
        }

        public void Update(TimeSpan starttime, TimeSpan endtime, string activity, int employeeid, int overtimerequestid)
        {
            this.StartTime = starttime;
            this.EndTime = endtime;
            this.Activity = activity;
            this.EmployeeId = employeeid;
            this.OvertimeRequestId = overtimerequestid;
        }
    }
}
