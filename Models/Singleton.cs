using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Models
{
    sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton()
        {
            counter += 1;
            Console.WriteLine($"[Counter Value]: {counter}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        //public class Derived : Singleton
        //{

        //}
    }
}
