using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Hashset
{
    internal class EmployeeInterface
    {
        public class Employee
        {
            public string Name { get; set; }
            public int Salary{ get; set; }
        }

        public class CheckSalary : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)// x=p1, y=p2
            {
                if (x.Salary > y.Salary)
                {
                    return 1;
                }
                else if (x.Salary < y.Salary)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class Program1
        {
            static void Main(string[] args)
            {
                Employee e1 = new Employee { Name = "Ali", Salary = 80000 };
                Employee e2 = new Employee { Name = "Suyash", Salary = 40000 };

                CheckSalary c = new CheckSalary();

                int result = c.Compare(e1, e2);
                if (result == 1)
                {
                    Console.WriteLine("Ali has more Salary then Suyash");
                }
                else if (result == -1)
                {
                    Console.WriteLine("Ali has Less salary then Suaysh");
                }
                else
                {
                    Console.WriteLine("Both have Same Salary");
                }
            }
        }
    }




}

