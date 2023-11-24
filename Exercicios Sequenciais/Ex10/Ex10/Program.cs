namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, variavel, resto, nota;

            Console.WriteLine("Gostaria de sacar quantos R$: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N; //Resto vai obter o mesmo valor que foi solicitado, sendo assim, se foi solicitado "352" o resto da divisão passa a valer "352" também.

            nota = 100; // quando o 100 não poder mais dividir o valor Solicitado, o restante da divisão passa para 50, e continua assim até que todas as notas sejam lidas.
            variavel = resto / nota;
            Console.WriteLine(variavel + "notas de R$" + nota);
            resto = resto % nota; // aqui o 100  já não pode mais dividir o valor, logo ele passa para a casa do 50.

            nota = 50;
            variavel = resto / nota;
            Console.WriteLine(variavel + "notas de R$" + nota);
            resto = resto % nota;

            nota = 20;
            variavel = resto / nota;
            Console.WriteLine(variavel + "notas de R$" + nota);
            resto = resto % nota;

            nota = 10;
            variavel = resto / nota;
            Console.WriteLine(variavel + "notas de R$" + nota);
            resto = resto % nota;

            nota = 5;
            variavel = resto / nota;
            Console.WriteLine(variavel + "notas de R$" + nota);
            resto = resto % nota;

            nota = 2;
            variavel = resto / nota;
            Console.WriteLine(variavel + "notas de R$" + nota);
            resto = resto % nota;

            nota = 1;
            variavel = resto / nota;
            Console.WriteLine(variavel + "notas de R$" + nota);
        }
    }
}