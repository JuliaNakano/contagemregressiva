using System;

namespace contagemregressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Preparar...");
            Console.ReadKey();
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("Apontar...");
            Console.ReadKey();
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("FOGO!");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
