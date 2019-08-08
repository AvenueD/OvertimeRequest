using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class SiteVM
    {
        // Apa yang dibutuhkan di View dan Model, yg diinputkan secara sadar diletakan di ViewModel
        public string Name { get; set; }
        public string Address { get; set; }

        public SiteVM() { } // constructor
        public SiteVM(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public void Update(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
