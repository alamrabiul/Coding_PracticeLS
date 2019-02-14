using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodsExample
{
    public class Animal
    {
        //base class

        public Animal() { }
        public void Sleep() { }
        public bool IsHungry = true;
        public virtual void Eat()
        {
            Console.WriteLine("Eat Something");
        }
    }

    public class Elephant : Animal
    {
        public int CarryCapacity;
        public override void Eat()
        {
            Console.WriteLine("Eat Grass");
        }
    }
    public class Mouse : Animal
    {
       
        public override void Eat()
        {
            Console.WriteLine("Eat cheese");
        }
    }
    public class Cat : Animal
    {
        public void StalkPrey() {  }
        public override void Eat()
        {
            Console.WriteLine("Eat mouse");
        }
    }
    public class WildLife
    {
        public WildLife()
        {
            Elephant objElephant = new Elephant();
            Mouse objMouse = new Mouse();
            Cat objCat = new Cat();

            FeedingTime(objElephant);
            FeedingTime(objMouse);
            FeedingTime(objCat);
        }

        public void FeedingTime(Animal objAnimal)
        {
            //Notice use of polymorphism here
            if (objAnimal.IsHungry)
            {
                objAnimal.Eat();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            WildLife objWildLife = new WildLife();
            Console.ReadKey();
        }
    }
}

/* OUTPUT:
 * Eat Grass 
 * Eat cheese
 * Eat mouse
*/    
