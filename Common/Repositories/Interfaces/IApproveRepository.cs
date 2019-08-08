using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IApproveRepository
    {
        List<Approve> Get();
        Approve Get(int id);
        //List<Approve> Get(string value);
        bool Insert(ApproveVM approveVM);
        bool Update(int id, ApproveVM approveVM);
        bool Delete(int id);
    }
}
