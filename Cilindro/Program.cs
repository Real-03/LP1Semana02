using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double height = 0.0, raio = 0.0;
            Console.Write("Introduz a altura do cilindro: ");
            height=double.Parse(Console.ReadLine());
            Console.Write("Introduz o Raio do cilindro: ");
            raio=double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(Math.PI*Math.Pow(raio,2)*height,3));
            Console.WriteLine(Math.Round(2*Math.PI*raio*(raio+height),3));
        }
    }
}
