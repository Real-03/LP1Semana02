using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            byte number = 0;
            Console.Write("Insere número inteiro-não negativo: ");
            number =byte.Parse(Console.ReadLine());
            Console.WriteLine(number/2);
            Console.WriteLine(number<<3);
            Console.WriteLine(number^6);
            Console.WriteLine(number>10);
        }
    }
}
