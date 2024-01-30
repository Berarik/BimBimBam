using System;

namespace BimBam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coin = new Random();
            string helloworld = "Hello, World!";
            if(helloworld.Length<10)
                Console.WriteLine(helloworld);
            else
                Console.WriteLine(helloworld[coin.Next(0, helloworld.Length)]);

            int intN = 500;
            Console.WriteLine($"Число: {(intN < 123 ? 1 : 2)}");
            
            int flipCoin = coin.Next(0, 2);
            Console.WriteLine($"Выбопало:{ ((flipCoin == 0) ? "Orel" : "Reshka")}");
            for (int i = 0;i<10;i++)
            {
                Console.WriteLine($"Выбопало (Номер попытки {i}): {((coin.Next(0, 2) == 0) ? "Orel" : "Reshka")} ");
            }

        }
    }
}
