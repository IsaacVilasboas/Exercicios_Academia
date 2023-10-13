namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[20];
            int[] w = new int[20];
            for (int i = 0; i < 20; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i =0; i < 20; i++)
            {
                Console.Write(v[i]);
            }
            Console.WriteLine();
            for (int i = 19;i >= 0; i--) 
            {
                w[i] = v[i];
                Console.Write(w[i]);
            }
        }
    }
}
//int[] vetor = new int[5] { 0, 1, 2, 3, 4 };
//int[] vetorInvertido = new int[5];

//int posicao = (vetor.Length - 1);

//for (int i = 0; i < vetor.Length; i++)
//{
//    vetorInvertido[posicao] = vetor[i];
//    posicao--;
//}

//for (int i = 0; i < vetor.Length; i++)
//{
//    Console.WriteLine("vetor normal [" + i + "] = " + vetor[i]);
//}

//for (int i = 0; i < vetorInvertido.Length; i++)
//{
//    Console.WriteLine("vetor invertido [" + i + "] = " + vetorInvertido[i]);
//}