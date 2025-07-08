using System.Diagnostics.CodeAnalysis;

namespace Assignment1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            Console.WriteLine("The first 10 natural number is: ");
            for (int n = 1; n < 11; n++)
            {
                Console.Write(n + " ");
                sum = n + i;
                i = sum;
                
            }
            Console.WriteLine();
            Console.WriteLine("The Sum is: " + sum);
        }
    }
}
