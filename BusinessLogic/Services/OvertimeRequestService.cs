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
    public class OvertimeRequestService : IOvertimeRequestService
    {
        bool status = false;

        private readonly IOvertimeRequestRepository _overtimeRequestRepository;

        public OvertimeRequestService(IOvertimeRequestRepository overtimeRequestRepository)
        {
            _overtimeRequestRepository = overtimeRequestRepository;
        }

        public OvertimeRequestService() { }

        public List<OvertimeRequest> Get()
        {
            var result = _overtimeRequestRepository.Get();
            return result;
        }

        public OvertimeRequest Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _overtimeRequestRepository.Get(id);
                return result;
            }
        }

        public bool Insert(OvertimeRequestVM overtimerequestVM)
        {
            if(string.IsNullOrWhiteSpace(overtimerequestVM.OvertimeDate.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.OvertimeDate.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.UploadFile.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.DateApproveRM.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.DateApproveFin.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.ApproveId.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.SiteId.ToString()))
            {
                return status;
            }
            else
            {
                var result = _overtimeRequestRepository.Insert(overtimerequestVM);
                return result;
            }
        }

        /*public bool Update(int id, OvertimeRequestVM overtimerequestVM)
        {
            if (string.IsNullOrWhiteSpace(Id.ToString()) || overtimerequestVM.OvertimeDate.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.OvertimeDate.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.UploadFile.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.DateApproveRM.ToString()) || string.IsNullOrWhiteSpace(overtimerequestVM.DateApproveFin.ToString()))
            {
                return status;
            }
            else
            {
                var result = _overtimeRequestRepository.Update(id, overtimerequestVM);
                return result;
            }
        }*/

        /*public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _overtimeRequestRepository.Delete(id);
                return result;
            }
        }*/
    }
}
