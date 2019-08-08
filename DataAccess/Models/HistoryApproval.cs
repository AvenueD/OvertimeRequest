using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_R_History_Approvals")]
    public class HistoryApproval : BaseModel
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
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        /*public void Update(HistoryApprovalVM historyapprovalVM) // Pembuatan Constructor untuk Update
        {
            this.EmployeeName = historyapprovalVM.EmployeeName;
            this.OvertimeDate = historyapprovalVM.OvertimeDate;
            this.TotalTime = historyapprovalVM.TotalTime;
            this.Status = historyapprovalVM.Status;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }*/
        /*public void Delete() // Pembuatan Constructor untuk Delete
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }*/
    }
}
