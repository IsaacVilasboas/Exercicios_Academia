namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salario, totalvendas;
      
            Console.WriteLine("Qual o nome do funcionário ? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o salário do funcionario ?");
            salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual foi o valor das vendas ?");
            totalvendas = int.Parse(Console.ReadLine());
          
            int porcentagem = totalvendas;

            if (totalvendas > 500 && porcentagem < 1000) {
                salario = salario + ( 5 * porcentagem) / 100;
                Console.WriteLine(salario);
            }
            else if (porcentagem >= 1000 && porcentagem < 5000) {
                salario = salario + ( 7 * porcentagem) / 100;
                Console.WriteLine(salario);
            }
            else if (totalvendas >= 5000) { 
                salario = salario + ( 10 * porcentagem) / 100;
                Console.WriteLine(salario);
            }

        }
    }
}
//8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
//Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
//Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
//E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
//total de vendas.