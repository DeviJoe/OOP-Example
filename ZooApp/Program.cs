using System;
using ZooApp.lib;

namespace ZooApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal tortoise = new Tortoise("Торчилла", 1, 2);
            Animal tiger = new Tiger("Apex", 2);
            Animal crocodile = new Crocodile("Геннадий", 5, 50);
            
            tortoise.Log();
            Console.WriteLine();
            tiger.Log();
            Console.WriteLine();
            crocodile.Log();
            Console.WriteLine();
            
        }
    }
}