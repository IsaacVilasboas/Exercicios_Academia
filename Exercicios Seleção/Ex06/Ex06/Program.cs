namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome ?");
            string nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Qual é a sua altura?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos kg pesa?");
            double kg = double.Parse(Console.ReadLine());

            double imc = kg / (altura * altura);
            if (imc < 18)
            {
                Console.WriteLine(imc);
                Console.WriteLine("Baixo peso");
            }
            else if (imc > 18 && imc < 25)
            {
                Console.WriteLine(imc);
                Console.WriteLine("Peso Normal");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine(imc);
                Console.WriteLine("sobrepeso");
            }
            else if (imc > 30 && imc < 35)
            {
                Console.WriteLine(imc);
                Console.WriteLine("Obesidade");
            }
            else if (imc > 35)
            {
                Console.WriteLine(imc);
                Console.WriteLine("Obesidade grau sério");
            }
        }
    }
}
//6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
//O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
//O cálculo do imc = peso / (altura * altura)

//IMC
//menor que 18                -> baixo peso
//maior que 18 e menor que 25 -> peso normal
//maior que 25 e menor que 30 -> sobrepeso
//maior que 30 e menor que 35 -> obesidade
//maior que 35                -> obesidade grau sério
