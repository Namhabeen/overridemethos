using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Power(int input)
        {
            return input * input;

        }
        static int Power(int input, int count)
        {
            int num = 1;
            for (int i = 0; i < count; i++)
            {
                num = num * input;
            }
            return num;
        }
        static int SumAll(int end)
        {
            int sum = 0;
            for (int i = 0; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
        static int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Power(4)); Console.WriteLine(Power(4));

            Console.WriteLine(Power(7,9)); Console.WriteLine(Power(7, 9));

            Console.WriteLine(SumAll(8)); Console.WriteLine(SumAll(8));

            Console.WriteLine(SumAll(2, 9)); Console.WriteLine(SumAll(2, 9));
        }
    }
}
   

