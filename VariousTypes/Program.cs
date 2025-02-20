using System;
using System.Text;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 40;
            uint j = 6U;
            long l = 60L;
            int hex = 0x05;
            ulong n = 4000UL;
            int bin = 0b101110;

            Console.WriteLine($"x: {x}, j: {j}, l: {l}, hex: {hex}, n: {n}, bin : {bin} ");

            char char1 = '\u9731';
            char char2 = '\x9816';
            char char3 = '\u2605';
            

            Console.WriteLine($"char 1: {char1}, char2: {char2}, char3: {char3} ");

        }
    }
}
