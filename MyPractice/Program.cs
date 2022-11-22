using System;
using System.Security.Cryptography.X509Certificates;

namespace Hello
{
    class Program
    {

        public static int RecFac(int a)
        {
            return (a==0 ? 1 : a * RecFac(a-1));
        }
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecFac(a));
        }
    }
}