﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class OvertimeRequestVM
    {
        public DateTime? OvertimeDate { get; set; }
        public string UploadFile { get; set; }
        public DateTime? DateApproveRM { get; set; }
        public DateTime? DateApproveFin { get; set; }
        public int ApproveId { get; set; }
        public int SiteId { get; set; }

        public OvertimeRequestVM() { }

        public OvertimeRequestVM(DateTime? overtimedate, string uploadfile, DateTime? dateapproverm, DateTime? dateapprovefin, int approveid, int siteid)
        {
            this.OvertimeDate = overtimedate;
            this.UploadFile = uploadfile;
            this.DateApproveRM = dateapproverm;
            this.DateApproveFin = dateapprovefin;
            this.ApproveId = approveid;
            this.SiteId = siteid;
        }

        public void Update(DateTime? overtimedate, string uploadfile, DateTime? dateapproverm, DateTime? dateapprovefin, int approveid, int siteid)
        {
            this.OvertimeDate = overtimedate;
            this.UploadFile = uploadfile;
            this.DateApproveRM = dateapproverm;
            this.DateApproveFin = dateapprovefin;
            this.ApproveId = approveid;
            this.SiteId = siteid;
        }
    }
}
