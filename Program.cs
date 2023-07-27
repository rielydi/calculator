using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Quais funções deseja utilizar na calculadora? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtraçôes");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Selecione uma opção");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break; // system.environment.exit é para sair do sistema. o zero é que significa que saiu com sucesso.
                default: Menu(); break; //seria se o usuario digitasse qualquer outra tecla sem ser as pedias.
            }




        }
        static void Soma()

        {
            Console.WriteLine("Digite o primeiro valor: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");

            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            //Console.WriteLine("O resultado da soma é: " + resultado); é a mesma coisa que o de cima. o $ é interpolação de string
            //tem a possibilidade de Console.WritLine($"O resultado da soma é: {v1 + v2}");
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.WriteLine("Escreva o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            Console.WriteLine($"o Resultado dessa subtração é: {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado} ");

            Console.ReadKey();
            Menu();
        }
    }

}