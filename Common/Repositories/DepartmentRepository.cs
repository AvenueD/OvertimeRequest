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
    public class DepartmentRepository : IDepartmentRepository
    {

        bool status = false;
        //Membuat Objek
        ApplicationContext applicationContext = new ApplicationContext();


        public List<Department> Get()//Get all
        {
            var get = applicationContext.Departments.Include("Division").Where(x => x.IsDelete == false).ToList();
            return get; //Contextnya,nama table, kondisi
        }

        /*public List<Department> Get(string value)//Get by Value String
        {
            var get = applicationContext.Departments.Where(x => (x.Name.Contains(value) || x.Id.ToString().Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }*/
        
        public Department Get(int id)//Get by Id
        {
            var get = applicationContext.Departments.Include("Division").SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(DepartmentVM departmentVM)
        {
            var push = new Department(departmentVM);
            applicationContext.Departments.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
        public bool Update(int id, DepartmentVM departmentVM)
        {
            //Untuk mengambil data By Id
            var get = Get(id);
            if (get != null)
            {
                get.Update(departmentVM);
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;

            }
            else
            {
                return false;
            }
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
