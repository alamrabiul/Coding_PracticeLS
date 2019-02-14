using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleTwo
{
    interface ICarnivore
    {
        bool IsHungry { get; }
        Animal Hunt();
        void Eat(Animal victim);
    }
    public abstract class Animal
    {
        public abstract void Sleep();
    }
    public class Antelope : Animal
    {
        public override void Sleep() { }
        
    }

    public class Lion : Animal, ICarnivore
    {
        public Lion()
        {
            hungry = true;
        }

        //ICarnivore implementation
        

        private bool hungry;
        public bool IsHungry
        {
            get
            {
                return hungry;
            }
        }
        public Animal Hunt()
        {
            //hunt and capture implementation
            return new Antelope();
        }
        public void Eat(Animal prey)
        {
            //implementation
            Console.WriteLine("Lion is no longer hungry");

        }

        //Inherited from base class
        public override void Sleep()
        {
            //Sleeping
        }

        public void JoinPrde()
        {
            //Join with a Pride of other Lions
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Lion aLion = new Lion();
            Antelope a = new Antelope();

            //carnivore-like behavior
            if(aLion.IsHungry)
            {
                Animal victim = aLion.Hunt();
                if (victim != null)
                {
                    aLion.Eat(victim);
                }
            }

            //Lion specific
            aLion.JoinPrde();
            //Animal behavior
            aLion.Sleep();
            Console.ReadKey();
        }
    }
}
