using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Base;
using DataAccess.ViewModels;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("TB_M_Regency")]
    public class Regency : BaseModel
    {
        public string Name { get; set; }
        public Province Province { get; set; }

        public Regency() { }

        public Regency(RegencyVM regencyVM)
        {
            this.Name = regencyVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(RegencyVM regencyVM)
        {
            this.Name = regencyVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
