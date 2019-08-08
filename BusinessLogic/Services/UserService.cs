using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {
        bool status = false;
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> Get()
        {
            var result = _userRepository.Get();
            return result;
        }

        /*public List<User> Get(string value)
        {
            throw new NotImplementedException();
        }*/

        public User Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _userRepository.Get(id);
                return result;
            }
        }

        public bool Insert(UserVM userVM)
        {
            if (string.IsNullOrWhiteSpace(userVM.Email) || string.IsNullOrWhiteSpace(userVM.Password))

            {
                return status;
            }
            else
            {
                var result = _userRepository.Insert(userVM);
                return result;
            }
        }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _userRepository.Delete(id);
                return result;
            }
        }
        public bool Update(int id, UserVM userVM)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(userVM.Email) || string.IsNullOrWhiteSpace(userVM.Password))
            {
                return status;
            }
            else
            {
                var result = _userRepository.Update(id, userVM);
                return result;
            }
        }
    }
}
