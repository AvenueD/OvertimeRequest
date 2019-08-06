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
        public string UploadFile { get; set; }
        public DateTime? DateApproveRM { get; set; }
        public DateTime? DateApproveFin { get; set; }
        public Approve Approve { get; set; }
        public Site Site { get; set; }

        public OvertimeRequest() { }

        public OvertimeRequest(OvertimeRequestVM overtimerequestVM)
        {
            this.OvertimeDate = overtimerequestVM.OvertimeDate;
            this.UploadFile = overtimerequestVM.UploadFile;
            this.DateApproveRM = overtimerequestVM.DateApproveRM;
            this.DateApproveFin = overtimerequestVM.DateApproveFin;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(OvertimeRequestVM overtimerequestVM)
        {
            this.OvertimeDate = overtimerequestVM.OvertimeDate;
            this.UploadFile = overtimerequestVM.UploadFile;
            this.DateApproveRM = overtimerequestVM.DateApproveRM;
            this.DateApproveFin = overtimerequestVM.DateApproveFin;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
