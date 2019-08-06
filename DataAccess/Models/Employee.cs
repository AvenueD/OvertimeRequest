using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Base;
using DataAccess.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public Employee Manager { get; set; }
        public Department Department { get; set; }
        public Religion Religion { get; set; }
        public Village Village { get; set; }
        public Position Position { get; set; }

        public Employee() { } // constructor
        public Employee(EmployeeVM employeeVM)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.PhoneNumber = employeeVM.PhoneNumber;
            this.Gender = employeeVM.Gender;
            this.Address = employeeVM.Address;
            this.Salary = employeeVM.Salary;
            //this.Manager = employeeVM.Manager;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(EmployeeVM employeeVM)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.PhoneNumber = employeeVM.PhoneNumber;
            this.Gender = employeeVM.Gender;
            this.Address = employeeVM.Address;
            this.Salary = employeeVM.Salary;
            //this.Manager = employeeVM.ManagerId;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;

        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}