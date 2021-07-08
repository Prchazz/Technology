using System;
namespace Technology
{
    public abstract class AbstractEntity
    {
        private static int min = 1000;
        private static int max = 9999;
        private static Random _rdm = new Random();
        
        public AbstractEntity() { }
        
        public void GenerateRandomNumber()
        {

            int randomNum = _rdm.Next(min, max);
            Console.WriteLine(randomNum);
        }


    }
}
