using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1, DOdaj");

                Console.WriteLine("3, Exit");
                
                Console.WriteLine("3, Odejmij");

                Console.WriteLine("4, Mnozenie");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 3)
                    break;

            }
        }
    }
}
