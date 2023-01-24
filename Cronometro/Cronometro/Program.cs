using System;

namespace Cronometro
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
            Console.WriteLine("S = Segundo\nM = Minuto\n0 = Sair");
            Console.WriteLine("\nQuanto tempo deseja contar?");
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(2500);
        }
    }
}