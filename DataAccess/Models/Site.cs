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
    [Table("TB_M_Sites")]
    public class Site : BaseModel
    {
        public Site() { } // constructor
        public Site(SiteVM siteVM)
        {
            this.Name = siteVM.Name;
            this.Address = siteVM.Address;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(SiteVM siteVM)
        {
            this.Name = siteVM.Name;
            this.Address = siteVM.Address;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }

        public string Name { get; set; }
        public string Address { get; set; }
    }
}