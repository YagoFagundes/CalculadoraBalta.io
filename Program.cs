using Calculadora.Operacoes;
using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {

            Pagina.paginafundo();
            Console.SetCursorPosition(10,4);
            Console.WriteLine("CALCULAORA");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("1 - Opção Somar");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("2 - Opção Subtração");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("3 - Opção Divisão");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("4 - Opção Multiplicação");
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("5 - Opção Porcentagem");
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("6 - Opção RaizQuadrada");
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("7 - SAIR!");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine("-------------------------------");
            Console.SetCursorPosition(2, 14);
            Console.WriteLine("Digite Qual Opção Voce Quer:");
            Console.SetCursorPosition(2, 15);
            int index = int.Parse(Console.ReadLine());

            switch (index)
            {
                case 1:Soma.soma();break;
                case 2:Subtracao.subtracao(); break;
                case 3:Divisao.divisao(); break;
                case 4:Multiplicacao.multiplicacao(); break;
                case 5:Porcentagem.porcentagem(); break;
                case 6:RaizQuadrada.raizQuadrada(); break;
                case 7: System.Environment.Exit(0); break;
                default: Console.WriteLine("Escolha uma Opção Valida");Menu();break;

            }
        }
        //static void Soma()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Por Favor Digite o Primeiro valor: ");
        //    float valor1 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Por Favor Digite o Segundo valor: ");
        //    float valor2 = float.Parse(Console.ReadLine());

        //    float resultado = valor1 + valor2;
        //    Console.WriteLine($"O Resultado da Soma é: {resultado}");
        //    Menu();

        //}
        //static void Subtracao()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Por Favor Digite o Primeiro valor: ");
        //    float valor1 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Por Favor Digite o Segundo valor: ");
        //    float valor2 = float.Parse(Console.ReadLine());

        //    float resultado = valor1 - valor2;
        //    Console.WriteLine($"O Resultado da Subtração é: {resultado}");
        //    Menu();
        //}
        //static void Divisao()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Por Favor Digite o Primeiro valor: ");
        //    float valor1 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Por Favor Digite o Segundo valor: ");
        //    float valor2 = float.Parse(Console.ReadLine());

        //    float resultado = valor1/valor2;
        //    Console.WriteLine($"O Resultado da Divisão é: {resultado}");
        //    Menu();
        //}
        //static void Multiplicacao()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Por Favor Digite o Primeiro valor: ");
        //    float valor1 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Por Favor Digite o Segundo valor: ");
        //    float valor2 = float.Parse(Console.ReadLine());

        //    float resultado = valor1 * valor2;
        //    Console.WriteLine($"O Resultado da Multiplicação é: {resultado}");
        //    Menu();
        //}
        //static void Porcentagem()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Por Favor Digite qual a Porcentagem que voçê Procura: ");
        //    float valor1 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Por Favor Digite qual o valor para a Porcentagem: ");
        //    float valor2 = float.Parse(Console.ReadLine());

        //    float resultado1 = valor1 / 100;
        //    float resultado2 = resultado1 * valor2;
        //    int resultadoFinal = (int)Math.Round(resultado2);

        //    Console.WriteLine($"A Porcentagem equivale a: {resultadoFinal}");
        //    Menu();
        //}
        //static void RaizQuadrada()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Por Favor Digite o Valor Inteiro para saber a Raiz quadrada: ");
        //    int valor1 = int.Parse(Console.ReadLine());

        //    float res = (float) Math.Sqrt(valor1);

        //    if (res % 1 == 0)
        //    {
        //        Console.WriteLine($"A Raiz Quadrada de {valor1} é Exata, Valor é: {res}");

        //    }
        //    else
        //    {
        //        Console.WriteLine($"A Raiz Quadrada de {valor1} não é exata, Valor é: {res}");
        //    }
        //    Menu();
        //}
    }
}
