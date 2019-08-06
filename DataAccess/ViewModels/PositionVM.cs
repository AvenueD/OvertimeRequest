using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class PositionVM
    {
        // Apa yang dibutuhkan di View dan Model, yg diinputkan secara sadar diletakan di ViewModel
        public string Name { get; set; }
        public PositionVM() { } // constructor
        public PositionVM(string name)
        {
            this.Name = name;
        }
        public void Update(string name)
        {
            this.Name = name;
        }
    }
}