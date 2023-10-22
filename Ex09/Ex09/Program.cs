namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int[] w = new int[10];
            for (int i = 0; i < 10; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(v); 
            for (int i = 0;i < v.Length;i++)
            {
                w[i] = v[i];
                Console.WriteLine(w[i]);
            }
        }
    }
}
//int[] vetor = new int[10] { 10, 7, 3, 6, 9, 1, 2, 5, 8, 4 };
//int aux = 0;

//for (int i = 0; i < vetor.Length; i++)
//{
//    for (int j = 0; j < (vetor.Length - 1); j++)
//    {
//        if (vetor[j + 1] < vetor[j])
//        {
//            aux = vetor[j];
//            vetor[j] = vetor[j + 1];
//            vetor[j + 1] = aux;
//        }
//    }
//}

//for (int i = 0; i < vetor.Length; i++)
//{
//    Console.WriteLine("Vetor[" + i + "] = " + vetor[i]);
//}