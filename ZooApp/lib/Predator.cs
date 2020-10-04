using System;

namespace ZooApp.lib
{
    public abstract class Predator : Animal
    {
        protected Predator(int id, string name, int voliereNum) : base(id, name, voliereNum)
        {
        }

        protected Predator(string name, int voliereNum) : base(name, voliereNum)
        {
        }

        public override void Voice()
        {
            Console.WriteLine("РРРРР!!!!!! Я злой хищник");
        }

        public override void Attack()
        {
            Console.WriteLine("Иди сюда, ща п****ть(бить) буду");
        }

        public override bool Sit()
        {
            try
            {
                Console.WriteLine("Хищник сел и хочет кушоц");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        
    }
}