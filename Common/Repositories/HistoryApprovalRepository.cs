using Common.Repositories.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class HistoryApprovalRepository : IHistoryApprovalRepository
    {
        private bool status = false;
        ApplicationContext applicationContext = new ApplicationContext();


        public List<HistoryApproval> Get()//Get all
        {
            var get = applicationContext.HistoryApprovals.Where(x => x.IsDelete == false).ToList();
            return get; //Contextnya,nama table, kondisi
        }

        public HistoryApproval Get(int id)//Get by Id
        {
            var get = applicationContext.HistoryApprovals.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(HistoryApprovalVM historyapprovalVM)
        {
            var push = new HistoryApproval(historyapprovalVM);
            applicationContext.HistoryApprovals.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
        /*public bool Update(int id, HistoryApprovalVM historyapprovalVM)
        {
            var get = Get(id);
            get.Update(historyapprovalVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }*/

        /*public bool Delete(int id)
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
        }*/
    }
}
