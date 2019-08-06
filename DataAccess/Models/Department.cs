using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Base;
using DataAccess.ViewModels;

namespace DataAccess.Models
{
    public class Department : BaseModel
    {
        public string Name { get; set; }

        public Department() { }
        public Department(DepartmentVM departmentVM)
        {
            this.Name = departmentVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(DepartmentVM departmentVM) // Pembuatan Constructor untuk Update
        {
            this.Name = departmentVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete() // Pembuatan Constructor untuk Delete
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }

    }
}
