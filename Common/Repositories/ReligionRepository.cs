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
    public class ReligionRepository : IReligionRepository
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

        public List<Religion> Get()
        {
            var get = applicationContext.Religions.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Religion Get(int id)
        {
            var get = applicationContext.Religions.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(ReligionVM religionVM)
        {
            var push = new Religion(religionVM);
            applicationContext.Religions.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, ReligionVM religionVM)
        {
            var get = Get(id);
            get.Update(religionVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}
