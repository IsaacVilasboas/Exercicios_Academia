using System;

namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual foi o placar do jogo ?");
            string[] vet = Console.ReadLine().Split('x');
            int t1 = int.Parse(vet[0]);
            int t2 = int.Parse(vet[1]);
            int t3 = t1 - t2;
            int t4 = t2 - t1;

            if (t1 > t2 && t3 >= 2)
            {
                Console.WriteLine("o time de casa já se classificou");
           }

            else if (t2 > t1 && t4 >= 2)
            {
                Console.WriteLine("o time de fora já se classificou");
            }
            else if (t1 >= t2 || t3 >= 1)
            {
                Console.WriteLine("os dois times se enfrentarão em um novo jogo");
                Console.WriteLine("novo jogo");
               t1 = int.Parse(Console.ReadLine());
                t2 = int.Parse(Console.ReadLine());
                if (t1 > t2)
               {
                    Console.WriteLine("o time de casa se classificou");
                }
                else if(t1 < t2)
                {
                    Console.WriteLine("o time de fora se classificou");
                }
            }
            else if (t1 <= t2 || t4 >= 1)
            {
                Console.WriteLine("os dois times se enfrentarão em um novo jogo");
            }
        }
    }             
}
//Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
//na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
//enfrentar novamente em um novo jogo.
//ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
//ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
//plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase