using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Site : BaseModel
    {
        public Site() { } // constructor
        public Site(SiteVM siteVM)
        {
            this.Name = siteVM.Name;
            this.Address = siteVM.Adrress;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(SiteVM siteVM)
        {
            this.Name = siteVM.Name;
            this.Address = siteVM.Adrress;
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