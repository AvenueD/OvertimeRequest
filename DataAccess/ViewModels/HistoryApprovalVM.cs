using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class HistoryApprovalVM
    {
        public string EmployeeName { get; set; }
        public DateTime? OvertimeDate { get; set; }
        public int TotalTime { get; set; }
        public string Status { get; set; }

        public HistoryApprovalVM() { }

        public HistoryApprovalVM(string employeename, DateTime? overtimedate, int totaltime, string status)
        {
            this.EmployeeName = employeename;
            this.OvertimeDate = overtimedate;
            this.TotalTime = totaltime;
            this.Status = status;
        }
        public void Update(string employeename, DateTime? overtimedate, int totaltime, string status) // Pembuatan Constructor untuk Update
        {
            this.EmployeeName = employeename;
            this.OvertimeDate = overtimedate;
            this.TotalTime = totaltime;
            this.Status = status;
        }
    }
}
