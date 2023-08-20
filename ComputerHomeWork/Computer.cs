using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHomeWork
{
    internal class Computer
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public ComputerTypes type { get; set; }
        public double Ghz { get; set; }
        public int Hafiza { get; set; }
        public double EkranBoyutu { get; set; }
        public bool SuSogutmaliMi { get; set; }
        public DateTime UretimTarihi { get; set; }

    }
}
