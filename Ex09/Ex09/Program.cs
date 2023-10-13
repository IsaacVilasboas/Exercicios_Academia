using System;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quais são os valores de Glicemia ?");
            string[] vet = Console.ReadLine().Split(' ');
            int G1 = int.Parse(vet[0]);
            int G2 = int.Parse(vet[1]);
            int G3 = int.Parse(vet[2]);

            int glicemia = G1 + G2 + G3;
            double insulina = glicemia / 3.0;

            if (glicemia < 65)
            {
                Console.WriteLine("Glicemia = " + glicemia);
                Console.WriteLine("Você corre risco de hipoglicemia");
                
            }
            else if (glicemia > 250)
            {
                Console.WriteLine("Glicemia = " + glicemia);
                Console.WriteLine("Você corre risco de hiperglicemia");
                
            }
            if (insulina < 80)
                {
                    Console.WriteLine("Você precisa diminuir 2 unidades de insulina.");
                }
            else if (insulina > 150)
                {
                    Console.WriteLine("Você precisa adicionar 2 unidades de insulina.");
                }
        }
    }
}
//Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
//diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
//Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
//Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia