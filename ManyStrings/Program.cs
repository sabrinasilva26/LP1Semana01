using System;
using System.Reflection.PortableExecutable;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
        //strings

        string message = "pode ser utilizada assim";
        string text2 = "strings são um conjunto de caracteres";
        string path = "/Users/sabrinasilva/Documents/MinhaPastaDeLP1/LP1Semana01/ManyStrings/Program.cs";
        string character = "podemos ter caracteres de escape exp: \t \\";
        string simbolo =  "podemos ter um simbolo \u2607";

        Console.WriteLine(message);
        Console.WriteLine(text2);
        Console.WriteLine(path);
        Console.WriteLine(character);
        Console.WriteLine(simbolo);

        string concatenacao1 = "Aluno" + "s"; 
        string concatenacao2 = "b" + 2;
        int x = 6;
        int y = 3;
        string interpolacao = $"O João tem {x} rebuçados e gastou {y},ficou com {x-y}";
        string interpolacao2 = $"A maria tem {8} anos e para o ano faz {8+1}";
        
        Console.WriteLine(interpolacao);
        Console.WriteLine(concatenacao1);
        Console.WriteLine(concatenacao2);
        Console.WriteLine($"A sala tem : {concatenacao1}");
        Console.WriteLine(interpolacao2);


        }
    }
}
