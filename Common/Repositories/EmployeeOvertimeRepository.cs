using Common.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using System.Data.Entity;

namespace Common.Repositories
{
    public class EmployeeOvertimeRepository : IEmployeeOvertimeRepository
    {
        bool status = false;
        //Membuat Objek
        ApplicationContext applicationContext = new ApplicationContext();


        public List<EmployeeOvertime> Get()//Get all
        {
            var get = applicationContext.EmployeeOvertimes.Include("Employee").Include("OvertimeRequest").Where(x => x.IsDelete == false).ToList();
            return get; //Contextnya,nama table, kondisi
        }

        /*public List<OvertimeRequest> Get(string value)//Get by Value String
        {
            var get = applicationContext.OvertimeRequests.Where(x => (x.Id.ToString().Contains(value)) || x.DateOvertime.ToString().Contains(value) && x.IsDelete == false).ToList();
            return get;
        }*/

        public EmployeeOvertime Get(int id)//Get by Id
        {
            var get = applicationContext.EmployeeOvertimes.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(EmployeeOvertimeVM employeeovertimeVM)
        {
            var push = new EmployeeOvertime(employeeovertimeVM);
            var getEmployee = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeovertimeVM.EmployeeId);
            push.Employee = getEmployee;
            var getOvertime = applicationContext.OvertimeRequests.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeovertimeVM.OvertimeRequestId);
            push.OvertimeRequest = getOvertime;
            applicationContext.EmployeeOvertimes.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        /*public bool Update(OvertimeRequestVM overtimerequestVM)
        {
            //Untuk mengambil data By Id
            var get = Get(id);
            if (get != null)
            {
                get.Update(overtimerequestVM);
                var getAction = applicationContext.Actions.SingleOrDefault(x => x.IsDelete == false && x.Id == overtimerequestVM.Action);
                get.Action = getAction;
                var getSite = applicationContext.Sites.SingleOrDefault(x => x.IsDelete == false && x.Id == overtimerequestVM.Site);
                get.Site = getSite;
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
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
