using System;
namespace Technology
{
    public class Computer : Technology
    {

        public string[] Features { get; set; }
        public Computer(string name, string oss, int hardDrive, string[] features)
            : base(name, oss, hardDrive)
        {
            this.Features = features;
           
        }

        public void PrintComputerFeatures()
        {
            foreach (string feature in this.Features)
                Console.WriteLine(feature);
        }
      

    
       
    }
}
