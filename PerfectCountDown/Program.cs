using System;

namespace PerfectCountDown
{
    public class Program
    {
        private static void Main(string[] args)
        {

            int start=0, step = 0;
            bool response = false;
            do{
                Console.Write("Start Number:");
                start = Int32.Parse(Console.ReadLine());
                Console.Write("Step Number:");
                step = Int32.Parse(Console.ReadLine());

                if(start <1 || step <1)
                {
                    Console.WriteLine("Out-of-range start or step: Try again");
                }
                else if(start <= step)
                {
                    Console.WriteLine("Start must be higher then step: Try again");
                }
                else if(start%step!=0)
                {
                    Console.WriteLine("Start not divisible by step: Try again");
                }
                else
                {
                    response = true;
                }


            }while(response == false);
            for(int i = start; i>=0; i-=step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
