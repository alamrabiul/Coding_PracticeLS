using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseArrayasMethodParameters
{
    public class  MathArray
    {
        public int Sum(int[] numberList)
        {
            int sum = 0;
            foreach(int number in numberList)
            {
                sum += number;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathArray objMathArray = new MathArray();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int total = objMathArray.Sum(numbers);
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
//Output : 28