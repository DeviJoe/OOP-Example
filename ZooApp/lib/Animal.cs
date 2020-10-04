using System;

namespace ZooApp.lib
{
    public abstract class Animal : IComparable<Animal>
    {
        /*
         * Знаю шо говно, но для демонстрации сойдет
         */
        protected static int IDCounter = 0;
        
        private  int Id {get; }
        private  string Name { get;  }
        private int VoliereNum { get; set; }
        
        
        protected Animal(int id, string name, int voliereNum)
        {
            
            Id = id;
            Name = name;
            VoliereNum = voliereNum;
        }

        protected Animal(string name, int voliereNum)
        {
            Name = name;
            VoliereNum = voliereNum;
            Id = ++IDCounter;
        }

        public virtual void Voice()
        {
            Console.WriteLine("Я - животное!!!");
        }

        public virtual bool Sit()
        {
            try
            {
                Console.WriteLine("Животное село (на 8 лет)");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "Ошиб очка - животное не село");
                throw;
            }
        }

        public virtual void Attack()
        {
            Console.WriteLine("Ща животное как вдарит! Но не знаю, умею драться или нет");
        }

        public virtual void Log()
        {
        
            Console.WriteLine(ToString());
            Console.WriteLine("Хэш: " + GetHashCode());
            Console.Write("Атака: ");
            Attack();
            Console.Write("Сесть: ");
            Sit();
            Console.Write("Голос: ");
            Voice();
        }

        protected bool Equals(Animal other)
        {
            return Id == other.Id && Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Animal) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }

        public int CompareTo(Animal other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var idComparison = Id.CompareTo(other.Id);
            if (idComparison != 0) return idComparison;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
        
        
    }
}