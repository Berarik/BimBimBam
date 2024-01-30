using System;

namespace BimBam
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello, World!";
            if(helloworld.Length<10)
                Console.WriteLine(helloworld);
            else
                Console.WriteLine(helloworld[5]);

        }
    }
}
