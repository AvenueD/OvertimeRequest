using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class HistoryApproval
    {
        public string EmployeeName { get; set; }
        public DateTime? OvertimeDate { get; set; }
        public int TotalTime { get; set; }
        public string Status { get; set; }

        public HistoryApproval() { }
        public HistoryApproval(HistoryApprovalVM historyapprovalVM)
        {
            this.EmployeeName = historyapprovalVM.EmployeeName;
            this.OvertimeDate = historyapprovalVM.OvertimeDate;
            this.TotalTime = historyapprovalVM.TotalTime;
            this.Status = historyapprovalVM.Status;
        }
    }
}
