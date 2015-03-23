using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the string "Hello" and concatinate the Main argument at index '0'
            //Console.WriteLine("Hello "+ args[0]);


            //Print FirstName LastName
            ////Print args string index 0 and 1
            //Console.Write(args[0] + " " + args[1]);


            //Print LastName, FirstName
            //Print args string index 1 and 0 with the string "," in the middle.
            Console.Write(args[1] + "," + args[0]);


            //Read Line
            Console.ReadLine();
        }
    }
}
