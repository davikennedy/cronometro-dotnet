using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cronômetro: ");

            Start();
            Console.ReadKey();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while(currentTime != time)
            {                
                currentTime++;
                Console.WriteLine(currentTime);
            }
        }
    }
}