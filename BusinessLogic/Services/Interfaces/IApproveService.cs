using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IApproveService
    {
        List<Approve> Get();
        Approve Get(int id);
        //List<Approve> Get(string value);
        bool Insert(ApproveVM ActionVM);
        bool Update(int id, ApproveVM ActionVM);
        bool Delete(int id);
    }
}
