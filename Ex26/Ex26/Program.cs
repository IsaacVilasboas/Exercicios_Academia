namespace Ex26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double totalsalario = 0;
            double totalfilhos = 0;
            double contpessoas = 0;
            double salarioMaior = double.MinValue;
            double porcentagem = 0;
            double mediasF = 0;
            double mediaS = 0;
            int salariomenor = 0;
            
            while (true)
            {
                Console.WriteLine("Qual o salario dos funcionarios ?");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0)
                {
                    Console.WriteLine("Progama encerrado");
                    break;
                }
                Console.WriteLine("Quantos filhos tem ?");
                int filhos = int.Parse(Console.ReadLine());

                totalsalario += salario;
                totalfilhos += filhos;
                contpessoas++;
                if (salario > salarioMaior)
                {
                    salarioMaior = salario;
                }
                if (salario <= 100)
                {
                    salariomenor++;
                }
            }
            if(contpessoas > 0)
            {
                mediaS = totalsalario / contpessoas;
                mediasF = totalfilhos / contpessoas;
                porcentagem = (double)salariomenor / (contpessoas * 100.0);

                Console.WriteLine("A média do salário da população é: " + mediaS);
                Console.WriteLine("A média do número de filhos da população é: " +  mediasF);
                Console.WriteLine("O maior salário é: " + salarioMaior);
                Console.WriteLine("O percentual de pessoas com o salário até R$100,00 é : " + salariomenor);
            }
        }
    }
}