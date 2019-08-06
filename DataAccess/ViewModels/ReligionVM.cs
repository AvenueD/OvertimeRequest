using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ReligionVM
    {
        public string Name { get; set; }

        public ReligionVM() { }
        public ReligionVM(string name) // Pembuatan construct
        {
            this.Name = name;
        }
        public void Update(string name) // Pembuatan Constructor untuk Update
        {
            this.Name = name;
        }
    }
}
