using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Coluna " + i + " digite o valores da " + (j + 1) + " linha: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0;i < 4; i++)
            {

                for(int j = 0;j < 4; j++)
                {
                    Console.Write( "[" + m[i, j] + "]");
                }
                Console.WriteLine(i);
            }
            Console.Write("A matriz principal é ");
            Console.WriteLine();
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine(m[i, i] + " ");
            }
        }
    }
}