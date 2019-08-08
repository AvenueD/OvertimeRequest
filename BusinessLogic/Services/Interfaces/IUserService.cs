using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IUserService
    {
        //Interface hanya membuat method kosong
        List<User> Get();
        User Get(int id);
        //List<User> Get(string value);
        bool Insert(UserVM userVM);
        bool Update(int id, UserVM userVM);
        bool Delete(int id);
    }
}
