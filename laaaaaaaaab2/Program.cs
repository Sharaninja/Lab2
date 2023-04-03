using System;
using System.Collections.Generic;

namespace DelegateLambdaExample
{
    class Program
    {
        delegate int StringLength(string str);

        static void Main(string[] args)
        {
            List<string> strings = new List<string>
            {
                "phone",
                "two",
                "game",
                "ball"
               
            };

            StringLength length = s => s.Length;

            Console.WriteLine("Lengths of strings:");
            foreach (var str in strings)
            {
                Console.WriteLine(length(str));
            }
            Console.ReadLine();
        }
    }
}

