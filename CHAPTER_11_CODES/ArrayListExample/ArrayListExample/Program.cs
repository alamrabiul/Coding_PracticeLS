using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add(123);
            arrList.Add("Mahedee Hasan");
            arrList.Add(DateTime.Now);
            arrList.Remove(123);
            arrList.Clear();
            arrList.Insert(0, "Hasanur Rahman");
            arrList.Add("Newaz Sharif");
            arrList.Reverse();

            foreach( var item in arrList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }

    //Output : Newaz Sharif
    //         Hasanur Rahman      
}
