using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class ApproveRepository : IApproveRepository
    {
        bool status = false;
        ApplicationContext applicationContext = new ApplicationContext();

        public List<Approve> Get()
        {
            var get = applicationContext.Approves.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        /*public List<Site> Get(string value)
        {
            var get = applicationContext.Sites.Where(x => (x.Id.ToString().Contains(value) || x.Name.Contains(value) || x.Value.ToString().Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }*/

        public Approve Get(int id)
        {
            var get = applicationContext.Approves.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(ApproveVM approveVM)
        {
            var push = new Approve(approveVM);
            applicationContext.Approves.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, ApproveVM approveVM)
        {
            var get = Get(id);
            get.Update(approveVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete(); // Parsing
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }
    }
}
