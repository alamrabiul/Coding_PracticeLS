using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    public class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lstEmplyoee = new List<Employee>();
            Employee se = new Employee();
            se.Name = "Abdullah Yousuf";
            se.Designation = "Software Engineer";

            lstEmplyoee.Add(se);

            Employee sse = new Employee();
            sse.Name = "Anamul Haque";
            sse.Designation = "Senior Software Engineer";

            lstEmplyoee.Add(sse);

            Employee sa = new Employee();
            sa.Name = "Mahedee Hasan";
            sa.Designation = "Software Architect";

            lstEmplyoee.Add(sa);

            Employee ssa = new Employee();
            ssa.Name = "Tanvir Reza Haque";
            ssa.Designation = "Senior Software Architect";

            lstEmplyoee.Add(ssa);

            Employee mgr = new Employee();
            mgr.Name = "Faizur Rahman";
            mgr.Designation = "Manager";

            lstEmplyoee.Add(mgr);

            foreach (var employee in lstEmplyoee)
            {
                Console.WriteLine(employee.Name + " Designation: " +
                    employee.Designation);
            }

                Employee pm = new Employee();
                pm.Name = "Ahsan Kabir";
                pm.Designation = "Project Manager";
                lstEmplyoee.Insert(1, pm);

                Console.WriteLine(lstEmplyoee[1].Name + "Designation:" +
                    lstEmplyoee[1].Designation);
                Console.WriteLine(lstEmplyoee.Count);


                lstEmplyoee.Reverse();
                lstEmplyoee.RemoveAll(p => p.Name == "Mahedee Hasan");

                foreach( var employee in lstEmplyoee) 
                {
                    Console.WriteLine(employee.Name + " Designation: " +
                        employee.Designation);
                }
                Console.ReadKey();
            }
        }
    }

