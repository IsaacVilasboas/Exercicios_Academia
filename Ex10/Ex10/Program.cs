class Program
{
    static bool Primo(int numero) //função Primo
    {
        if (numero <= 1)
        {
            return false; // 0 e 1 não são primos
        }

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) // o único número par que é primo é o 2, sendo assim, os outros números primos são todos impares.
            {                       //qualquer número que seja dividido por "i" não será primo. 
                return false; 
            }
        }

        return true; // O número é primo
    }

    static void Main()
    {
        while (true) //sempre que for iniciar uma repetição e n tiver nenhum valor, utilizar sempre o true
        {
            Console.Write("Digite um número (ou 0 para sair): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {   // se o número for = a 0 iremos sair do loop
                break; //utilizado para encerrar uma ação.
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " é par ");
            }
            else
            {
                Console.WriteLine(numero + " é ímpar ");
            }

            if (Primo(numero))
            {
                Console.WriteLine(numero + " Ele é primo");
            }
            else
            {
                Console.WriteLine(numero + " Ele não é primo.");
            }
        }
    }
}

