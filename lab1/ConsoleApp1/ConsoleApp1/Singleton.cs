using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1
{
    public class Creater
    {
        private static Creater instance;
        public string Email { get; private set; }

        private static object syncRoot = new Object();
        private Creater(string _email)
        {
            Email = _email;
        }

        public static Creater getInstance(string email)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new Creater(email);
                }
            }
            return instance;
        }
    }
    public class Singleton
    {
        public string Date { get; private set; }
        public static string text = "hello";
        private Singleton()
        {
            Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static Singleton GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
            return Nested.instance;
        }

        private class Nested
        {
            static Nested() { }
            internal static readonly Singleton instance = new Singleton();
        }
    }
}


