using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IOvertimeRequestService
    {
        List<OvertimeRequest> Get();
        OvertimeRequest Get(int id);
        //List<OvertimeRequest> Get(string value);
        bool Insert(OvertimeRequestVM overtimeRequestVM);
        //bool Update(OvertimeRequestVM overtimerequestVM);
        //bool Delete(int id);
    }
}
