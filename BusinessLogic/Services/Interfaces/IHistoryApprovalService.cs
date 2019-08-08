using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IHistoryApprovalService
    {
        List<HistoryApproval> Get();
        HistoryApproval Get(int id);
        bool Insert(HistoryApprovalVM historyapprovalVM);
        //bool Update(int id, HistoryApprovalVM historyapprovalVM);
        //bool Delete(int id);
    }
}
