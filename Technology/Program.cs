using System;
using Technology;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Technology tech1 = new Technology("Server", "VMWARE", 900);
            string[] tech2Features = { "DVD Drive", "Fast processor", "Video Card" };
            Computer tech2 = new Computer ("imac", "Mojave OS", 750, tech2Features);
            string[] tech3Features = { "portable", "speakers", "touch screen" };
            Laptop tech3 = new Laptop("Macbook Pro", "Yosimite OS", 500, tech3Features, 15);
            tech1.GetTechInfo();
            tech1.GenerateRandomNumber();
            Console.WriteLine("<---------------->");
            tech2.GetTechInfo();
            tech2.PrintComputerFeatures();
            tech2.GenerateRandomNumber();
            Console.WriteLine("<---------------->");
            tech3.GetTechInfo();
            tech3.GenerateRandomNumber();
            tech3.PrintScreenSize();
            Console.WriteLine("<---------------->");
            Smartphone tech4 = new Smartphone ( "Iphone", "IOS", 128, "5G" );
            tech4.GetTechInfo();
            tech4.GenerateRandomNumber();
            tech4.PrintAntenna();
            

        }
    }
}
