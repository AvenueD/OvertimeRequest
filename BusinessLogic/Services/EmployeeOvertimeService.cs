using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class EmployeeOvertimeService : IEmployeeOvertimeService
    {
        bool status = false;

        private readonly IEmployeeOvertimeRepository _employeeOvertimeRepository;

        public EmployeeOvertimeService(IEmployeeOvertimeRepository employeeOvertimeRepository)
        {
            _employeeOvertimeRepository = employeeOvertimeRepository;
        }

        public EmployeeOvertimeService() { }

        public List<EmployeeOvertime> Get()
        {
            var result = _employeeOvertimeRepository.Get();
            return result;
        }

        public EmployeeOvertime Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _employeeOvertimeRepository.Get(id);
                return result;
            }
        }

        public bool Insert(EmployeeOvertimeVM employeeovertimeVM)
        {
            if (string.IsNullOrWhiteSpace(employeeovertimeVM.StartTime.ToString()) || string.IsNullOrWhiteSpace(employeeovertimeVM.EndTime.ToString()) || string.IsNullOrWhiteSpace(employeeovertimeVM.Activity.ToString()) || string.IsNullOrWhiteSpace(employeeovertimeVM.EmployeeId.ToString()) || string.IsNullOrWhiteSpace(employeeovertimeVM.OvertimeRequestId.ToString()))
            {
                return status;
            }
            else
            {
                var result = _employeeOvertimeRepository.Insert(employeeovertimeVM);
                return result;
            }
        }
        public bool Update(int id, EmployeeOvertimeVM employeeovertimeVM)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(employeeovertimeVM.EndTime.ToString()) || string.IsNullOrWhiteSpace(employeeovertimeVM.Activity.ToString()) || string.IsNullOrWhiteSpace(employeeovertimeVM.EmployeeId.ToString()) || string.IsNullOrWhiteSpace(employeeovertimeVM.OvertimeRequestId.ToString()))
            {
                return status;
            }
            else
            {
                var result = _employeeOvertimeRepository.Update(id, employeeovertimeVM);
                return result;
            }
        }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _employeeOvertimeRepository.Delete(id);
                return result;
            }
        }
    }
}
