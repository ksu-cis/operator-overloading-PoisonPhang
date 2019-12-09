using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);

            Console.WriteLine("\nAddition");
            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");
            Console.WriteLine($"Object method Add: {one.Add(two)}");
            Console.WriteLine($"Operator: {one + two}");

            Console.WriteLine("\nSubtraction");
            Console.WriteLine($"Operator: {one - two}");

            Console.WriteLine("\nScaler");
            Console.WriteLine($"Operator: {2 * one}");
            Console.WriteLine($"Operator: {two * 2}");

            Console.WriteLine("\nComparison");
            Console.WriteLine($"Operator -: {one == two}");
            Console.WriteLine($"Operator +: {one == new Vector3(3, 4, 5)}");
            Console.WriteLine($"Operator +: {one != two}");
            Console.WriteLine($"Operator -: {one != new Vector3(3, 4, 5)}");

            Console.WriteLine("\nIncerment");
            Console.WriteLine($"Pre: {++one}");
            Console.WriteLine($"Post: {one++}");

            Console.WriteLine("\nMagnigtude");
            Console.WriteLine($"Operator: {~one}");

            Console.Write($"{one} is ");
            if (one)
            {
                Console.Write("truthy");
            }
            else
            {
                Console.Write("falsy");
            }

            Console.WriteLine();

            Console.Write($"{Vector3.Zero} is ");
            if (Vector3.Zero)
            {
                Console.Write("truthy");
            }
            else
            {
                Console.Write("falsy");
            }
        }
    }
}
