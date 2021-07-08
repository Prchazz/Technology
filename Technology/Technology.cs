using System;
namespace Technology
{
    public class Technology : AbstractEntity
    {
        public string Name { get; set; }
        public string Oss { get; set; }
        public int HardDrive { get; set; }
        
        

        public Technology(string name, string oss, int hardDrive)
        {
            this.Name = name;
            this.Oss = oss;
            this.HardDrive = hardDrive;
        }

        public void GetTechInfo()
        {
            Console.WriteLine($"My technology device which is named {this.Name}, runs the operating system {this.Oss}, with {this.HardDrive}GB of harddrive space.");
        }
        
    }
   
   
}
