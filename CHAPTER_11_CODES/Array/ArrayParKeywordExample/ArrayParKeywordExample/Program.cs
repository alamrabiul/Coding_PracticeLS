using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPaKeywordExample
{
    //Use of Params keyword


    public class ParamTest
    {
        public int Sum(params int[] listNumbers)
        {
            int total = 0;
            foreach (int number in listNumbers)
            {
                total += number;
            }
            return total;
        }


        public string Combine(string str1, string str2, params object[] others)
        {
            string combination = str1 + " " + str2;
            foreach (object obj in others)
            {
                combination += " " + obj.ToString();
            }
            return combination;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ParamTest objparamTest = new ParamTest();

            int total = objparamTest.Sum(1, 2, 3, 4, 5, 6, 7);
            Console.WriteLine(total);

            string combo = objparamTest.Combine("One", "two", "three", "four");
            Console.WriteLine(combo);

            combo = objparamTest.Combine("alpha", "beta");
            Console.WriteLine(combo);

            Console.ReadKey();
        }
    }
}

/* Output : 28
 * One , two , three, four
 * alpha, beta */