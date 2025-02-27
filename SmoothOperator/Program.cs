using System;
using System.ComponentModel;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Insere número inteiro: ");
            number =Int32.Parse(Console.ReadLine());
            Console.WriteLine(number--);
            Console.WriteLine(number++);
        }
    }
}
