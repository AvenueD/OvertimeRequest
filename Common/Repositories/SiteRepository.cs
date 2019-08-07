using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using LeaveRequest.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class SiteRepository : ISiteRepository
    {
        bool status = false;
        ApplicationContext applicationContext = new ApplicationContext();

        public List<Site> Get()
        {
            var get = applicationContext.Sites.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        /*public List<Site> Get(string value)
        {
            var get = applicationContext.Sites.Where(x => (x.Id.ToString().Contains(value) || x.Name.Contains(value) || x.Value.ToString().Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }*/

        public Site Get(int id)
        {
            var get = applicationContext.Sites.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(SiteVM SiteVM)
        {
            var push = new Site(SiteVM);
            applicationContext.Sites.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, SiteVM SiteVM)
        {
            var get = Get(id);
            get.Update(SiteVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Delete(int id)
        {
            var get = Get(id);
            get.Delete();
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}
