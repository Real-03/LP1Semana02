using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(char.MinValue);

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine(short.MaxValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(ushort.MinValue);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(uint.MinValue);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(ulong.MinValue);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(decimal.MinValue);

            double PositiveInf = double. PositiveInfinity ;
            double NegativeInf = double. NegativeInfinity;
            double Nan = double.NaN;
            
            Console.WriteLine(PositiveInf);
            Console.WriteLine(NegativeInf);
            Console.WriteLine(Nan);
            uint uintvalue2 = uint.MaxValue;
            Console.WriteLine(uintvalue2+1);
            float Overflow1 = float.MaxValue;
            float Overflow2 = float.MinValue;

            Console.WriteLine(2*Overflow1);
            Console.WriteLine(Overflow2*2);

        }
    }
}
