using System;

namespace Ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s, n;
            Random random = new Random();


             Console.WriteLine("Tente adivinhar o número que escolhi");
             Console.WriteLine("Possui 3 chances ");
             Console.WriteLine("Já pensei no número, boa sorte");
             int na = random.Next(1,10);
             int n1 = int.Parse(Console.ReadLine());
             if (n1 == na) 
                {
                    Console.WriteLine("Muito bem, você acertou");
                }
                else
                {
                    Console.WriteLine("Tente novamente");
                    Console.WriteLine("Possui 2 chances");
                     n1 = int.Parse(Console.ReadLine());
                    if (n1 == na)
                    {
                        Console.WriteLine("Muito bem, você acertou");
                    }
                    else
                    {
                        Console.WriteLine("Tente novamente");
                        Console.WriteLine("Possui 1 chances");
                        n1 = int.Parse(Console.ReadLine());
                        if (n1 == na)
                        {
                            Console.WriteLine("Aleluia, quase perde.");
                        }
                        else
                        {
                            Console.WriteLine("Infelizmente você perdeu");
                            Console.WriteLine("O número era " + na);
                        }

                    }
                }   
        }
    }
}