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
    [Table("TB_M_Position")]
    public class Position : BaseModel
    {
        public string Name { get; set; }

        public Position() { }

        public Position(PositionVM positionVM)
        {
            this.Name = positionVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(PositionVM positionVM)
        {
            this.Name = positionVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}