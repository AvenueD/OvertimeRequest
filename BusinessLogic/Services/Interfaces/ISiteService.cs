using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface ISiteService
    {
        List<Site> Get();
        Site Get(int id);
        //List<Site> Get(string value);
        bool Insert(SiteVM siteVM);
        bool Update(int id, SiteVM siteVM);
        bool Delete(int id);
    }
}
