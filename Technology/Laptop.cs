using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public int ScreenSize { get; set; }
        public Laptop(string name, string oss, int hardDrive, string[] features, int screenSize)
        : base(name, oss, hardDrive, features)
        {
            this.ScreenSize = screenSize;
        }
        public void PrintScreenSize()
        {
            Console.WriteLine(ScreenSize);
        }
       
    }
}
