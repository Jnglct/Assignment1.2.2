using System.Diagnostics.CodeAnalysis;

namespace Assignment1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will find the total natural numbers going to N, type in N: ");
            int naturalN = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine();

            Console.WriteLine("The first N natural number is: ");
            for (int i = 1; i <= naturalN; i++)
            {
                Console.Write(i + " ");
                sum += i;

                
                
            }
            Console.WriteLine();
         
            Console.WriteLine("The Sum is: " + sum);
            Console.Read();
        }
    }
}
