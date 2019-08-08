using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.ViewModels
{
   public class VillageVM
    {
        // Apa yang dibutuhkan di View dan Model, yg diinputkan secara sadar diletakan di ViewModel
        public string Name { get; set; }
        
        [ForeignKey("District")]
        public int DistrictId{ get; set; }

        public VillageVM() { } // constructor
        public VillageVM(string name, int districtid)
        {
            this.Name = name;
            this.DistrictId = districtid;
        }

        public void Update(string name, int districtid)
        {
            this.Name = name;
            this.DistrictId = districtid;
        }
    }
}