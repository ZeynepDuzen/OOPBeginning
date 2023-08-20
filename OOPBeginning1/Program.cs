using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBeginning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.Marka = "Mini";
            araba1.Model = "Cooper";
            araba1.TrafigeCikis = DateTime.Parse("07.02.22");
            araba1.BeygirGucu = 184;
            araba1.KapiSayisi = 3;
            araba1.MotorHacmi = 1600;
            string araba1Text = "";
            araba1Text += $"Marka : {araba1.Marka}\n";
            araba1Text += $"Model : {araba1.Model}\n";
            araba1Text += $"Tur : {araba1.Turu}({(int)araba1.Turu})\n";
            araba1Text += $"TrafigeCikis : {araba1.TrafigeCikis.ToShortDateString()}\n";
            araba1Text += $"BeygirGucu : {araba1.BeygirGucu} Hp\n";
            araba1Text += $"KapiSayisi : {araba1.KapiSayisi} kapi\n";
            araba1Text += $"MotorHacmi : {araba1.MotorHacmi} cm3\n";
            Console.WriteLine(araba1Text);

            Araba araba2 = new Araba();
            { 
            araba2.Marka = "Fiat";
            araba2.Model = "Doblo";
            araba2.Turu = ArabaTipi.Ticari;
            araba2.TrafigeCikis = new DateTime(2023,05,02);
            araba2.BeygirGucu = 68;
            araba2.KapiSayisi = 5;
            araba2.MotorHacmi = 1300;
            };
            Console.WriteLine("Marka : " + araba2.Marka + "\n" + "Model : " + araba2.Model + "\n" + 
            araba2.Turu + "\n" + araba2.TrafigeCikis.ToShortDateString() + "\n" + "BeygirGucu : " + araba2.BeygirGucu + "\n" + 
            "Kapisayisi : " + araba2.KapiSayisi + "\n" + "Motorhacmi : " + araba2.MotorHacmi);



            Console.Read();
        }
    }

    

}
