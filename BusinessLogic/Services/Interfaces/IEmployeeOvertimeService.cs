using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IEmployeeOvertimeService
    {
        List<EmployeeOvertime> Get();
        EmployeeOvertime Get(int id);
        //List<OvertimeRequest> Get(string value);
        bool Insert(EmployeeOvertimeVM employeeovertimeVM);
        //bool Update(OvertimeRequestVM overtimerequestVM);
        //bool Delete(int id);
    }
}
