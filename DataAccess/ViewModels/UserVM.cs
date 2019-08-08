using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class UserVM
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string StatusActive { get; set; }

        public UserVM() { } //constructor

        public UserVM(string email, string password, string statusactive)
        {
            this.Email = email;
            this.Password = password;
            this.StatusActive = statusactive;
        }

        public void Update(string email, string password, string statusactive)
        {
            this.Email = email;
            this.Password = password;
            this.StatusActive = statusactive;
        }
    }
}
