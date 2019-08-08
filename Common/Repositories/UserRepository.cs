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
    public class UserRepository : IUserRepository
    {
        bool status = false;
        //Membuat Objek
        ApplicationContext applicationContext = new ApplicationContext();
        private UserVM userVM;
        public List<User> Get()//Get all
        {
            var get = applicationContext.Users.Where(x => x.IsDelete == false).ToList(); //<< JOIN TABLE ROLE
            return get; //Contextnya,nama table, kondisi
        }
        public List<User> Get(string value)//Get by Value String
        {
            var get = applicationContext.Users.Where(x => (x.Email.Contains(value) || x.Id.ToString().Contains(value) ||x.Password.ToString().Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }
        public User Get(int id)//Get by Id
        {
            var get = applicationContext.Users.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }
        public bool Insert(UserVM userVM)
        {
            var push = new User(userVM);
            applicationContext.Users.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
        public bool Update(int id, UserVM userVM)
        {
        //Untuk mengambil data By Id  sebelum di Update
           var get = Get(id);
         get.Update(userVM);
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
