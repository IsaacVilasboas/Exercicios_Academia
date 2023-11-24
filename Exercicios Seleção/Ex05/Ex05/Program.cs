using System.Globalization;

namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a primeira nota ?");
            int nota1 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a segunda nota ?");
            int nota2 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (nota1 + nota2) / 2.0;

            if (media >= 7.0)
            {
                Console.WriteLine("Sua média é: " + media);
                Console.WriteLine("Aprovado!!");
            }
            else {
                Console.WriteLine("Sua média é: " + media);
                if (media >= 5)
                {
                    Console.WriteLine("Aprovado!!");
                }
            }
        }
    }
}
//5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
//se a média das duas notas for maior ou igual a 7,0. 

//Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
//é a média entre a nota do exame e a média das 2 notas. 
//Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
//escrever “Reprovado”