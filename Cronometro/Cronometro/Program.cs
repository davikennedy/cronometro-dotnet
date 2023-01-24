using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.Write("\nQuanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();

            if (data.Length == 1)
            {
                if (char.Parse(data) == '0') System.Environment.Exit(0);
                Menu();
            }

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));            

            int multiplier = 1;
            if (type == 'm') multiplier = 60;

            Start(time * multiplier);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();                
                Console.WriteLine(time);
                time--;
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}