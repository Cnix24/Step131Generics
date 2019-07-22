using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step131Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string> { Things = new List<string> { "Name1", "Name2" } };
            Employee<int> employeeNum = new Employee<int> { Things = new List<int> { 4, 8 } };

            employee.Things.ForEach(Console.WriteLine);
            employeeNum.Things.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
