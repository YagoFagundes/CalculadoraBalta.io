using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine(" ----- CALCULAORA-----");

            Console.WriteLine("1 - Opção Somar");
            Console.WriteLine("2 - Opção Subtração");
            Console.WriteLine("3 - Opção Divisão");
            Console.WriteLine("4 - Opção Multiplicação");
            Console.WriteLine("5 - Opção Porcentagem");
            Console.WriteLine("6 - Opção RaizQuadrada");
            Console.WriteLine("7 - SAIR!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Digite Qual Opção Voce Quer:");

            int index = int.Parse(Console.ReadLine());

            switch (index)
            {
                case 1:Soma();break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Porcentagem(); break;
                case 6: RaizQuadrada(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); Console.WriteLine("Escolha uma Opção Valida"); break;

            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite o Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite o Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;
            Console.WriteLine($"O Resultado da Soma é: {resultado}");
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite o Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite o Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;
            Console.WriteLine($"O Resultado da Subtração é: {resultado}");
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite o Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite o Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1/valor2;
            Console.WriteLine($"O Resultado da Divisão é: {resultado}");
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite o Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite o Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;
            Console.WriteLine($"O Resultado da Multiplicação é: {resultado}");
            Menu();
        }
        static void Porcentagem()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite qual a Porcentagem que voçê Procura: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite qual o valor para a Porcentagem: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado1 = valor1 / 100;
            float resultado2 = resultado1 * valor2;
            int resultadoFinal = (int)Math.Round(resultado2);

            Console.WriteLine($"A Porcentagem equivale a: {resultadoFinal}");
            Menu();
        }
        static void RaizQuadrada()
        {
            Console.Clear();
            Console.WriteLine("Por Favor Digite o Valor Inteiro para saber a Raiz quadrada: ");
            int valor1 = int.Parse(Console.ReadLine());

            float res = (float) Math.Sqrt(valor1);

            if (res % 1 == 0)
            {
                Console.WriteLine($"A Raiz Quadrada de {valor1} é Exata, Valor é: {res}");

            }
            else
            {
                Console.WriteLine($"A Raiz Quadrada de {valor1} não é exata, Valor é: {res}");
            }
            Menu();
        }
    }
}
