using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
   public class EmployeeVM
    {
        // Apa yang dibutuhkan di View dan Model, yg diinputkan secara sadar diletakan di ViewModel
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber{ get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        
        public int ManagerId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        [ForeignKey("Religion")]
        public int ReligionId { get; set; }

        [ForeignKey("Village")]
        public int VillageId { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }

        public EmployeeVM() { } // constructor
        public EmployeeVM(string firstname, string lastname, string phonenumber, bool gender, string address, int salary, int religionid, int villageid, int positionid, int managerid, int departmentid)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.PhoneNumber = phonenumber;
            this.Gender = gender;
            this.Address = address;
            this.Salary = salary;
            this.ReligionId = religionid;
            this.VillageId = villageid;
            this.PositionId = positionid;
            this.ManagerId = managerid;
            this.DepartmentId = departmentid;
        }

        public void Update(string firstname, string lastname, string phonenumber, bool gender, string address, int salary, int religionid, int villageid, int positionid, int managerid, int departmentid)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.PhoneNumber = phonenumber;
            this.Gender = gender;
            this.Address = address;
            this.Salary = salary;
            this.ReligionId = religionid;
            this.VillageId = villageid;
            this.PositionId = positionid;
            this.ManagerId = managerid;
            this.DepartmentId = departmentid;
        }
    }
}
