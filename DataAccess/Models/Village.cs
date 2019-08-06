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
    [Table("TB_M_Village")]
    public class Village : BaseModel
    {
        public string Name { get; set; }

        [ForeignKey("District")]
        public District District { get; set; }

        public Village() { }

        public Village(VillageVM villageVM)
        {
            this.Name = villageVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(VillageVM villageVM)
        {
            this.Name = villageVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
