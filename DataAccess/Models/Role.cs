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
    [Table("TB_M_Roles")]
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public Role() { }

        public Role(RoleVM roleVM)
        {
            this.Name = roleVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(RoleVM roleVM)
        {
            this.Name = roleVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
