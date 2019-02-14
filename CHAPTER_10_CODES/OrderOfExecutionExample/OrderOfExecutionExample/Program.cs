using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOfExecutionExample
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Constructing Animal");
        }
    }
    public class Elephant : Animal
    {
        public Elephant()
        {
            Console.WriteLine("Constructing Elephant");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elephant e = new Elephant();
            Console.ReadKey();
        }
    }
}
