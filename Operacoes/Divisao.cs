using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operacoes
{
    internal class Divisao
    {
        public static void divisao()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite o Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite o Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.Clear();

            float resultado = valor1 / valor2;
            Console.WriteLine($"O Resultado da Divisão é: {resultado}");
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
                case 1: salvarArquivo(resultado); break;
                case 2:
                    Console.WriteLine("Ok, Resultado Descartado!");
                    Console.WriteLine("Precione [Enter] para continuar! ");
                    Console.ReadLine();
                    break;
                default: Console.WriteLine("Escolha uma Opção Valida!"); menuSalvar(resultado); break;
            }
        }
        static void salvarArquivo(float resultado)
        {
            var path = (@"C:\resultado Balta\Resultado Divisao\resultado.txt");
            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(resultado);
            }
            Console.WriteLine($"Arquivo foi Salvo com Sucesso!! Caminho da Pasta {path} ");
            Console.WriteLine("Precione [Enter] para continuar! ");
            Console.ReadLine();
        }
    }
}
