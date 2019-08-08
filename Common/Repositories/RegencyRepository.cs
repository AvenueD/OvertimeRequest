using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using Common.Repositories.Interfaces;
using DataAccess.ViewModels;

namespace Common.Repositories
{
    public class RegencyRepository : IRegencyRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        public bool Delete(int id)
        {
            var get = Get(id);
            get.Delete();
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public List<Regency> Get()
        {
            var get = applicationContext.Regencies.Include("Province").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Regency Get(int id)
        {
            var get = applicationContext.Regencies.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(RegencyVM regencyVM)
        {
            var push = new Regency(regencyVM);
            //ini nih foreign key
            var getProvince = applicationContext.Provinces.SingleOrDefault(x => x.IsDelete == false && x.Id == regencyVM.ProvinceId);
            push.Province = getProvince;
            applicationContext.Regencies.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, RegencyVM regencyVM)
        {
            var get = Get(id);
            var getProvince = applicationContext.Provinces.SingleOrDefault(x => x.IsDelete == false && x.Id == regencyVM.ProvinceId);
            get.Province = getProvince;
            get.Update(regencyVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}
