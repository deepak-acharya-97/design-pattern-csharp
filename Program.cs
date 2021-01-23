using DesignPattern.Models;
using System;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton.Derived derived = new Singleton.Derived();
            Parallel.Invoke(() =>
            {
                PrintEmployeeDetails();
            },
            () =>
            {
                PrintStudentDetails();
            });
            Console.ReadKey();
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetSingletonEagerLazy;
            fromStudent.PrintDetails("From Student");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetSingletonEagerLazy;
            fromEmployee.PrintDetails("From Employee");
        }
    }
}
