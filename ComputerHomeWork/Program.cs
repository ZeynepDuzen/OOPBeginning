using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Id = 1;
            computer.Marka = "Asus";
            computer.Model = "VivoBook";
            computer.type = ComputerTypes.Laptop;
            computer.Ghz = 2.10;
            computer.Hafiza = 8;
            computer.EkranBoyutu = 15.6;
            computer.SuSogutmaliMi = false;
            computer.UretimTarihi = DateTime.Parse("14.02.2023");

            Console.WriteLine("Id : " + computer.Id + "\n" + "Marka : " + computer.Marka + "\n" + "Model : " +
            computer.Model + "\n" + "Tip : " + computer.type + "\n" + "Hiz : " + computer.Ghz + "\n" +
            "Hafiza : " + computer.Hafiza + "\n" + "EkranBoyutu : " + computer.EkranBoyutu + "\n" +
            "SuSogutmalimi : " + computer.SuSogutmaliMi + "\n" + "UretimTarihi : " + computer.UretimTarihi.ToShortDateString());  
            
               



            Console.Read();
        }
    }
}
