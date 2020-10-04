using System;

namespace ZooApp.lib
{
    public class Tortoise : Herbivore, ISwim, IComparable<Tortoise>
    {
        
        private int Speed { get;  }
        
        public Tortoise(int id, string name, int voliereNum, int speed) : base(id, name, voliereNum)
        {
            Speed = speed;
        }

        public Tortoise(string name, int voliereNum, int speed) : base(name, voliereNum)
        {
            Speed = speed;
        }

        public void Swim(string message)
        {
            Console.WriteLine("Я торчу (как Кепчуг) в луже по имени: " + message);
            Console.WriteLine("Моя турбоскорость - " + Speed);
        }

        public override bool Sit()
        {
            try
            {
                Console.WriteLine("Я не сяду");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        protected bool Equals(Tortoise other)
        {
            return base.Equals(other) && Speed == other.Speed;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Tortoise) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ Speed;
            }
        }

        public int CompareTo(Tortoise other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return Speed.CompareTo(other.Speed);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Speed)}: {Speed}";
        }

        public override void Log()
        {
            base.Log();
            Console.Write("Плавание: ");
            Swim("Болото админное");
        }
    }
}