using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere um número inteiro: ");
            string str = Console.ReadLine();
            int i = int.Parse(str);

            Console.WriteLine("Insere um número real: ");
            string str2 = Console.ReadLine();
            float f = float.Parse(str2);

            float soma = i + f;

            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
