using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operacoes
{
    internal class Porcentagem
    {
        public static void porcentagem()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite qual a Porcentagem que voçê Procura: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite qual o valor para a Porcentagem: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado1 = valor1 / 100;
            float resultado2 = resultado1 * valor2;
            int resultadoFinal = (int)Math.Round(resultado2);
            Console.Clear();


            Console.WriteLine($"A Porcentagem equivale a: {resultadoFinal}");
            Console.WriteLine("\n");
            menuSalvar(resultadoFinal);
            Console.Clear();
            Program.Menu();
        }
        static void menuSalvar(float resultadoFinal )
        {
            Console.WriteLine("Quer Salvar o Resultado dessa Equação?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: salvarArquivo(resultadoFinal); break;
                case 2:
                    Console.WriteLine("Ok, Resultado Descartado!");
                    Console.WriteLine("Precione [Enter] para continuar! ");
                    Console.ReadLine();
                    break;
                default: Console.WriteLine("Escolha uma Opção Valida!"); menuSalvar(resultadoFinal); break;
            }
        }
        static void salvarArquivo(float resultadoFinal)
        {
            var path = (@"C:\resultado Balta\Resultado Porcentagem\resultado.txt");
            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(resultadoFinal);
            }
            Console.WriteLine($"Arquivo foi Salvo com Sucesso!! Caminho da Pasta {path} ");
            Console.WriteLine("Precione [Enter] para continuar! ");
            Console.ReadLine();
        }
    }
}
