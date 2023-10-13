namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite algo para pesquisar:");
            string frase = Console.ReadLine();
            Console.WriteLine("Qual palavra deseja verificar se ela aparece na Frase ?");
            string palavra = Console.ReadLine();
            Console.WriteLine("Certo, farei a verificação");

            if (frase.Contains(palavra))
            {
                Console.WriteLine(" A palavra " + palavra + " encontra-se na frase");
            }
            else
            {
                Console.WriteLine("A palavra " + palavra + " não se encontra na frase");
            }
        }
    }
}
//7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
//O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
//exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

//string palavra = Console.ReadLine();    
//if (frase.Contains(palavra))
//{
//    Console.WriteLine(palavra + " aparece na frase");
//    //bloco de instruções caso a palavra esteja na frase
//} else
//{
//    Console.WriteLine(palavra + " não aparece na frase");
//    //bloco de instruções caso a palavra não esteja na frase
//}
