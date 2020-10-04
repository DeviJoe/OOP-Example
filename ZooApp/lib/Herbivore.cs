using System;

namespace ZooApp.lib
{
    public abstract class Herbivore : Animal
    {
        protected Herbivore(int id, string name, int voliereNum) : base(id, name, voliereNum)
        {
        }

        protected Herbivore(string name, int voliereNum) : base(name, voliereNum)
        {
        }

        public override void Voice()
        {
            Console.WriteLine("Я милое травоядное");
        }

        public override void Attack()
        {
            Console.WriteLine("Я не бью, я милый");
        }
    }
}