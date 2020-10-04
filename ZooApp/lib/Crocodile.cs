using System;

namespace ZooApp.lib
{
    public class Crocodile : Predator, ISwim
    {
        
        private int Damage { get;  }
        
        public Crocodile(int id, string name, int voliereNum, int damage) : base(id, name, voliereNum)
        {
            Damage = damage;
        }

        public Crocodile(string name, int voliereNum, int damage) : base(name, voliereNum)
        {
            Damage = damage;
        }

        public override void Attack()
        {
            Console.WriteLine("Получи свои " + Damage + " очков дамага");
        }

        protected bool Equals(Crocodile other)
        {
            return base.Equals(other) && Damage == other.Damage;
        }

        public int CompareTo(Crocodile other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return Damage.CompareTo(other.Damage);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Crocodile) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ Damage;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Damage)}: {Damage}";
        }

        public void Swim(string message)
        {
            Console.WriteLine("Я плыву по опасной речке: " + message);
        }

        public override void Log()
        {
            base.Log();
            Console.Write("Плавание: ");
            Swim("озеро им.Рикардо Римана");
        }
    }
}