using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operacoes
{
    internal class RaizQuadrada
    {
        public static void raizQuadrada()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite o Valor Inteiro para saber a Raiz quadrada: ");
            int valor1 = int.Parse(Console.ReadLine());

            float resultado = (float)Math.Sqrt(valor1);

            if (resultado % 1 == 0)
            {
                Console.Clear();
                Console.WriteLine($"A Raiz Quadrada de {valor1} é Exata, Valor é: {resultado}");

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"A Raiz Quadrada de {valor1} não é exata, Valor é: {resultado}");
            }
            Console.WriteLine("\n");
            menuSalvar(resultado);
            Console.Clear();
            Program.Menu();
        }
        static void menuSalvar(float resultado)
        {
            Console.WriteLine("Quer Salvar o Resultado dessa Equação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: salvarArquivo(res); break;
                case 2:
                    Console.WriteLine("Ok, Resultado Descartado!");
                    Console.WriteLine("Precione [Enter] para continuar! ");
                    Console.ReadLine();
                    break;
                default: Console.WriteLine("Escolha uma Opção Valida!"); menuSalvar(res); break;
            }
        }
        static void salvarArquivo(float res)
        {
            var path = (@"C:\resultado Balta\Resultado RaizQuadrada\resultado.txt");
            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(res);
            }
            Console.WriteLine($"Arquivo foi Salvo com Sucesso!! Caminho da Pasta {path} ");
            Console.WriteLine("Precione [Enter] para continuar! ");
            Console.ReadLine();
        }
    }
}
