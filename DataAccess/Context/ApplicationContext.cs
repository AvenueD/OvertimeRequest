using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("Overtime") { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HistoryApproval> HistoryApprovals { get; set; }
        public DbSet<OvertimeRequest> OvertimeRequests { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Regency> Regencies { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Approve> Approves { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<EmployeeOvertime> EmployeeOvertimes { get; set; }
    }
}
