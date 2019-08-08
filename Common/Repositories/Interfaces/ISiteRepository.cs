using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface ISiteRepository
    {
        List<Site> Get();
        Site Get(int id);
        //List<Site> Get(string value);
        bool Insert(SiteVM SiteVM);
        bool Update(int id, SiteVM SiteVM);
        bool Delete(int id);
    }
}
