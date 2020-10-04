using System;

namespace ZooApp.lib
{
    public class Tiger : Animal
    {
        public Tiger(int id, string name, int voliereNum) : base(id, name, voliereNum)
        {
        }

        public Tiger(string name, int voliereNum) : base(name, voliereNum)
        {
        }

        public override void Voice()
        {
            Console.WriteLine("Я тигр! РРРР!");
        }
        
    }
}