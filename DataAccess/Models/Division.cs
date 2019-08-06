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
    public  class Division : BaseModel
    {
        public string Name { get; set; }

        public Division() { }

        public Division(DivisionVM divisionVM)
        {
            this.Name = divisionVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(DivisionVM divisionVM) // Pembuatan Constructor untuk Update
        {
            this.Name = divisionVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete() // Pembuatan Constructor untuk Delete
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
