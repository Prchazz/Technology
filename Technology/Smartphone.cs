using System;
namespace Technology
{
    public class Smartphone : Technology
    {
        public string Antenna { get; set; }
        public Smartphone(string name, string oss, int hardDrive, string antenna)
        : base(name, oss, hardDrive)
        {
            this.Antenna = antenna;
        }

        public void PrintAntenna()
        {
            Console.WriteLine(Antenna);
        }
        
        
    }
}
