using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime_System;
using ClassLibrary1;


namespace Flip_vs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 =new Class1();
            Class2 c2 =new Class2();

            Console.WriteLine("Time In - TIme Out");

            Console.Write("Enter Employee Id: ");
            c1.Id = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Employee Name: ");
            c1.Name = Console.ReadLine();

            Console.WriteLine("Enter 24 hour clock:");
            Console.WriteLine();

            Console.Write("Enter Time In: ");
            c1.TimeIn = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Enter Time Out: ");
            c1.Timeout = TimeSpan.Parse(Console.ReadLine());



            Console.WriteLine("\nRECORD");
            Console.WriteLine("Employee Id: " + c1.Id);
            Console.WriteLine("Employee Name " + c1.Name);
            Console.WriteLine("Time In " + c1.TimeIn);
            Console.WriteLine("Time Out " + c1.Timeout);

            c2.Overtimehours(c1);
            c2.TotalHours(c1);











        }
    }
}
