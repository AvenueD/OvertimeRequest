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
    [Table("TB_T_OvertimeRequests")]
    public class OvertimeRequest : BaseModel
    {
        public DateTime? OvertimeDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string UploadFile { get; set; }
        public string Activity { get; set; }
        public DateTime? DateApproveRM { get; set; }
        public DateTime? DateApproveFinn { get; set; }
        public Status Status { get; set; }
        //public Site Site { get; set; }

        public OvertimeRequest() { }

        public OvertimeRequest(OvertimeRequestVM overtimerequestVM)
        {
            this.OvertimeDate = overtimerequestVM.OvertimeDate;
            this.StartTime = overtimerequestVM.StartTime;
            this.EndTime = overtimerequestVM.EndTime;
            this.UploadFile = overtimerequestVM.UploadFile;
            this.Activity = overtimerequestVM.Activity;
            this.DateApproveRM = overtimerequestVM.DateApproveRM;
            this.DateApproveFinn = overtimerequestVM.DateApproveFinn;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(OvertimeRequestVM overtimerequestVM)
        {
            this.OvertimeDate = overtimerequestVM.OvertimeDate;
            this.StartTime = overtimerequestVM.StartTime;
            this.EndTime = overtimerequestVM.EndTime;
            this.UploadFile = overtimerequestVM.UploadFile;
            this.Activity = overtimerequestVM.Activity;
            this.DateApproveRM = overtimerequestVM.DateApproveRM;
            this.DateApproveFinn = overtimerequestVM.DateApproveFinn;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete(OvertimeRequestVM overtimerequestVM)
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
