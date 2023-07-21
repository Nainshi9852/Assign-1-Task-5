using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using while
            Console.WriteLine("From 1 to 10 using while");
            int num = 1;
            while(num<=10)
            {
                Console.WriteLine(num);
                num++;
            }
            //using For
            Console.WriteLine("From 1 to 10 using For");
            for (int i =1; i<=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
