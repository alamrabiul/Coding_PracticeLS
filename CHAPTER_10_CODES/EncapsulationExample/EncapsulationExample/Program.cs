using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class Employee
    {
        private double salary;
        private double taxRate = 0.05;

        public string Name { get; set; }
        public double YearOfExp { get; set; }

        public double YearlyMedicalAllowance { get;  private set; }

        public Employee()
        {
            this.YearlyMedicalAllowance = 30000;
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 200000)
                    salary = value - value * taxRate;
                else
                    salary = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.Name = "Rafiqul Islam";
            objEmployee.YearOfExp = 7;
            objEmployee.Salary = 300000;

            Console.WriteLine(objEmployee.Name);
            Console.WriteLine("Salary: " + objEmployee.Salary);
            Console.WriteLine("Yearly Medical Allowanc: " +
                objEmployee.YearlyMedicalAllowance);
            Console.ReadLine();
        }
    }
}
