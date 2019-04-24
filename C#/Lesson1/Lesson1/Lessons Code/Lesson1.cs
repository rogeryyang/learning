using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            /* my first program in C# */
            /*Now with lessons in debugging!*/
            Console.WriteLine("Hello World");
            Console.WriteLine("Numerical Input below:");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input = {0}", input);
            Console.ReadKey();
        }
    }
}
