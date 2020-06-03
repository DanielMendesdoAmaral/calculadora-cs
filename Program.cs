using System;
using System.Drawing;

namespace calculadora_cs
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            do {
                Console.Clear();
                Calculadora a = new Calculadora();
                a.ConstruirCalculadora();
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
    }
}