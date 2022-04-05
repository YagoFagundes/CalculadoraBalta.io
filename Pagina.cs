using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Pagina
    {
        public static void paginafundo()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            pagina();
        }
        public static void pagina()
        {
            Console.Write("+");
            for (int i = 0; i < 30; i++)
              Console.Write("=");

            Console.Write("+");
            Console.Write("\n");

            for (int linha = 0; linha <=18; linha++)
            {
                Console.Write("|");
                for (int i = 0; i < 30; i++)

                    Console.Write(" ");
                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");
            for (int i = 0; i < 30; i++)
                Console.Write("=");

            Console.Write("+");
            Console.Write("\n");
        }
    }
}
