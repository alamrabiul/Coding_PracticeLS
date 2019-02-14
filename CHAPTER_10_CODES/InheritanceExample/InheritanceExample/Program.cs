using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Animal
    {
        public bool IsSleeping;
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
        public void Eat() { }
    }

    public class Antelope : Animal
    {

    }
    public class Lion : Animal
    {
        public void StalkPrey() { }
    }
    public class Elephant : Animal
    {
        public int CarryCapacity;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Elephant e = new Elephant();
            e.Sleep();
            Console.ReadKey();
        }
    }
}
