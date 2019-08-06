using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
   public class RegencyVM
    {
        // Apa yang dibutuhkan di View dan Model, yg diinputkan secara sadar diletakan di ViewModel
        public string Name { get; set; }
        
        [ForeignKey("Province")]
        public int ProvinceId { get; set; }

        public RegencyVM() { } // constructor
        public RegencyVM(string name)
        {
            this.Name = name;
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}