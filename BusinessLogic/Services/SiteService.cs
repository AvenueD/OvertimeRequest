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
    public class SiteService : ISiteService
    {
        bool status = false;
        //Menghubungkan ke Interface Repository yang berada di common...
        private readonly ISiteRepository _siteRepository;
        public SiteService(ISiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }

        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _siteRepository.Delete(id);
                return result;
            }
        }

        public List<Site> Get()
        {
            var result = _siteRepository.Get();
            return result;
        }

        public Site Get(int id)
        {
            if(string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _siteRepository.Get(id);
                return result;
            }
        }

        public bool Insert(SiteVM siteVM)
        {
            if (string.IsNullOrWhiteSpace(siteVM.Name)|| string.IsNullOrWhiteSpace(siteVM.Address))

            {
                return status;
            }
            else
            {
                var result = _siteRepository.Insert(siteVM);
                return result;
            }
        }

        public bool Update(int id, SiteVM siteVM)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(siteVM.Name) || string.IsNullOrWhiteSpace(siteVM.Address))
            {
                return status;
            }
            else
            {
                var result = _siteRepository.Update(id, siteVM);
                return result;
            }
        }
    }
}
