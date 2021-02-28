using System;
namespace TiraElDau
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            int resultat = 0;
            Random tirar = new Random();
            Console.WriteLine("Prem una tecla per tirar el dau");
            do
            {
                tecla = Console.ReadKey();
                resultat = tirar.Next(1, 6);
                Console.WriteLine("El resultat de tirar el dau és " + resultat);
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
}