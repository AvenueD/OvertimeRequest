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
    [Table("TB_T_Employee_Overtimes")]
    public class EmployeeOvertime : BaseModel
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Activity { get; set; }
        public Employee Employee { get; set; }
        public OvertimeRequest OvertimeRequest { get; set; }

        public EmployeeOvertime() { }

        public EmployeeOvertime(EmployeeOvertimeVM employeeovertimeVM)
        {
            this.StartTime = employeeovertimeVM.StartTime;
            this.EndTime = employeeovertimeVM.EndTime;
            this.Activity = employeeovertimeVM.Activity;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(EmployeeOvertimeVM employeeovertimeVM)
        {
            this.StartTime = employeeovertimeVM.StartTime;
            this.EndTime = employeeovertimeVM.EndTime;
            this.Activity = employeeovertimeVM.Activity;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete(EmployeeOvertimeVM employeeovertimeVM)
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
