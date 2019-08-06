using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Religion")]
    public class Religion : BaseModel
    {
        public string Name { get; set; }

        public Religion() { }

        public Religion(ReligionVM religionVM)
        {
            this.Name = religionVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(ReligionVM religionVM)
        {
            this.Name = religionVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}