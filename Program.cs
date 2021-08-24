using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multipliccao");
            Console.WriteLine("5 - Sair do Programa");

            Console.WriteLine("====================");
            Console.WriteLine("Selecione uma opcao: ");

            short resultado = short.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1 : Soma(); break;
                case 2 : Subtracao(); break;
                case 3 : Divisao(); break;
                case 4 : Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default : Menu(); break;
            }
        }
        static void Soma()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O Resultado da soma e " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine("O resultado da subtracao e " + resultado);
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine("O resultado da divisao entre os numeros e de " + resultado);

            Console.ReadKey();
            Menu();



        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("O valor da multiplicacao e de " + resultado);
            Console.ReadKey();
            Menu();
        }
    }
}
