using System;
namespace Exercicios01
{
    class AboutArrays
    {
        static string[] b = new string[5];
        static void Main(string[] args)
        {
            Console.WriteLine("You need to enter some names for the assignment:".ToUpper());

            Console.WriteLine("Name 01:");
            b[0] = Convert.ToString(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Name 02:");
            b[1] = Convert.ToString(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Name 03:");
            b[2] = Convert.ToString(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Name 04:");
            b[3] = Convert.ToString(Console.ReadLine());
            Console.Clear();

            int[,] c = new int[4, 4];

            c[0, 0] = 5000; c[0, 1] = 1000; c[0, 2] = 2000; c[0, 3] = 3000;
            c[1, 0] = 2034; c[1, 1] = 6237; c[1, 2] = 7384; c[1, 3] = 2367;
            c[2, 0] = 3853; c[2, 1] = 3859; c[2, 2] = 3749; c[2, 3] = 8395;
            c[3, 0] = 1249; c[3, 1] = 3333; c[3, 2] = 2354; c[3, 3] = 6484;

            int sum = c[0, 0] + c[0, 1] + c[0, 2] + c[0, 3];

            Console.WriteLine($"The sum of the values in column 0 is: {sum} which belongs to {b[0]}.");

        }




    }
}
