using DesignPattern.Models;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = new Singleton();
            fromEmployee.PrintDetails("From Employee");

            Singleton fromStudent = new Singleton();
            fromStudent.PrintDetails("From Student");

            Console.ReadLine();
        }
    }
}
