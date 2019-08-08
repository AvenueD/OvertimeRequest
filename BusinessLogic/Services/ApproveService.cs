using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class ApproveService : IApproveService
    {
        bool status = false;
        private readonly IApproveRepository _approveRepository;
        public ApproveService(IApproveRepository approveRepository)
        {
            _approveRepository = approveRepository;
        }
        //Get All
        public ApproveService() { }
        public List<Approve> Get()
        {
            var result = _approveRepository.Get();
            return result;
        }

        public Approve Get(int id)
        {
            if(string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _approveRepository.Get(id);
                return result;
            }
        }

        public bool Insert(ApproveVM approveVM)
        {
            if (string.IsNullOrWhiteSpace(approveVM.Name))

            {
                return status;
            }
            else
            {
                var result = _approveRepository.Insert(approveVM);
                return result;
            }
        }

        public bool Update(int id, ApproveVM approveVM)
        {
           if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(approveVM.Name))
            {
                return status;
            }
            else
            {
                var result = _approveRepository.Update(id, approveVM);
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
                var result = _approveRepository.Delete(id);
                return result;
            }
        }
    }
}
