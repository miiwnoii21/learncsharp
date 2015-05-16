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
            
            PrintHelloSomeone("miiw");

            PrintNumber(1, 2, 3, 4, 5, 6, 7, 8, 9, 10 );
            PrintNumber2(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);            


            Console.ReadKey();
        }

        static void PrintHelloSomeone(string name)
        {
            Console.WriteLine("hello {0}", name);

        }

        static void PrintNumber(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]= {1}", i, arr[i]);
            }
        }

        static void PrintNumber2(params int[] arr)
        {
            int i = 0;
            foreach (var item in arr)
            {
                Console.WriteLine("arr[{0}]= {1}", i++, item);
            }
        }
    }
}
