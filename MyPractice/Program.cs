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
            try
            {
                Console.Write("Enter a number : ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a >= 0)
                {
                    Console.WriteLine(RecFac(a));
                }
                else
                {
                    Console.WriteLine("Please enter a non-negative number");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}