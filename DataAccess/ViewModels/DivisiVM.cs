using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DivisiVM
    {
        // Apa yang dibutuhkan di View dan Model, yg diinputkan secara sadar diletakan di ViewModel
        public string Name { get; set; }
        public DivisiVM() { } // constructor
        public DivisiVM(string name)
        {
            this.Name = name;
        }
        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
