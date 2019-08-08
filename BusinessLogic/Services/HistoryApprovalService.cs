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
    public class HistoryApprovalService : IHistoryApprovalService
    {
        bool status = false;
        private readonly IHistoryApprovalRepository _historyapprovalRepository;
        public HistoryApprovalService(IHistoryApprovalRepository historyapprovalRepository)
        {
            _historyapprovalRepository = historyapprovalRepository;
        }
        //Get All
        public List<HistoryApproval> Get()
        {
            var result = _historyapprovalRepository.Get();
            return result;
        }

        public HistoryApproval Get(int id)
        {
            if(string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _historyapprovalRepository.Get(id);
                return result;
            }
        }

        public bool Insert(HistoryApprovalVM historyapprovalVM)
        {
            if (string.IsNullOrWhiteSpace(historyapprovalVM.EmployeeName)|| string.IsNullOrWhiteSpace(historyapprovalVM.OvertimeDate.ToString())|| string.IsNullOrWhiteSpace(historyapprovalVM.TotalTime.ToString()) || string.IsNullOrWhiteSpace(historyapprovalVM.Status))

            {
                return status;
            }
            else
            {
                var result = _historyapprovalRepository.Insert(historyapprovalVM);
                return result;
            }
        }
    }
}
