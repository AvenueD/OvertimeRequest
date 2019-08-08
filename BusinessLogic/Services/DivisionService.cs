using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ViewModels;
using DataAccess.Models;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class DivisionService : IDivisionService
    {
        bool status = false;
        private readonly IDivisionRepository _divisionRepository;
        public DivisionService(IDivisionRepository divisionRepository)
        {
            _divisionRepository = divisionRepository;
        }
        public List<Division> Get()
        {
            var result = _divisionRepository.Get();
            return result;
        }

        public Division Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _divisionRepository.Get(id);
                return result;
            }
        }

        public bool Insert(DivisionVM divisionVM)
        {
            if (string.IsNullOrWhiteSpace(divisionVM.Name))

            {
                return status;
            }
            else
            {
                var result = _divisionRepository.Insert(divisionVM);
                return result;
            }
        }
        public bool Update(int id, DivisionVM divisionVM)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(divisionVM.Name))
            {
                return status;
            }
            else
            {
                var result = _divisionRepository.Update(id, divisionVM);
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
                var result = _divisionRepository.Delete(id);
                return result;
            }
        }
    }
}
