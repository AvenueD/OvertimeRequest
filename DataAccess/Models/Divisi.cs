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
    public  class Divisi : BaseModel
    {
        public string Name { get; set; }

        public Divisi() { }

        public Divisi(DivisiVM divisiVM)
        {
            this.Name = divisiVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(DivisiVM divisiVM) // Pembuatan Constructor untuk Update
        {
            this.Name = divisiVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete() // Pembuatan Constructor untuk Delete
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
