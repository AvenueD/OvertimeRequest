using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DepartmentVM
    {
        public string Name { get; set; }

        public DepartmentVM() { }
        public DepartmentVM(string name)
        {
            this.Name = name;
        }
        public void Update(string name) // Pembuatan Constructor untuk Update
        {
            this.Name = name;
        }
    }
   
}