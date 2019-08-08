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
    public class DivisionRepository : IDivisionRepository
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

        public List<Division> Get()
        {
            var get = applicationContext.Divisions.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Division Get(int id)
        {
            var get = applicationContext.Divisions.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(DivisionVM divisionVM)
        {
            var push = new Division(divisionVM);
            applicationContext.Divisions.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, DivisionVM divisionVM)
        {
            var get = Get(id);
            get.Update(divisionVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}
