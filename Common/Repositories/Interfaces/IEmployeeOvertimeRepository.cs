using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IEmployeeOvertimeRepository
    {
        List<EmployeeOvertime> Get();
        EmployeeOvertime Get(int id);
        //List<OvertimeRequest> Get(string value);
        bool Insert(EmployeeOvertimeVM employeeovertimeVM);
        //bool Update(OvertimeRequestVM overtimerequestVM);
        //bool Delete(int id);
    }
}
