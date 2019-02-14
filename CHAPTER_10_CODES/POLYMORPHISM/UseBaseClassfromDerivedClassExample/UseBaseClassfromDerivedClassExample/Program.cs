using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseBaseClassfromDerivedClassExample
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eat Something");
        }
    }
    public class Cat : Animal
    {
        public void StalkPrey() { }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Eat small animals");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
            Console.ReadKey();
        }
    }
}
// Output:
/* Eat something
 * Eat small animals */