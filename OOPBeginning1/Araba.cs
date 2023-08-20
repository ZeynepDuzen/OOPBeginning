using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBeginning1
{
    internal class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; } = 4;
        public short BeygirGucu { get; set; }
        public double MotorHacmi { get; set; }
        public DateTime TrafigeCikis{ get; set; }
        public ArabaTipi Turu { get; set; } = ArabaTipi.Binek;

    }
}
