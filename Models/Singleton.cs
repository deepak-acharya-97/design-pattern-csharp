using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Models
{
    sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object obj = new object();
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        public static Singleton GetSingletonEagerLazy
        {
            get
            {
                return _instance.Value;
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
