namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Musica> list= new List<Musica>();
            int opcao;
            do
            {
                Console.WriteLine("1 - Tocar Música");
                Console.WriteLine("2 - Adicionar Música");
                Console.WriteLine("3 - para sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Playlist.PlayMusic(list);
                        break;
                    case 2:
                        Console.WriteLine("Adicionando Música");
                        Musica.AdicionarMusica(list);
                        break;
                        case 3:
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.ReadKey(true);
            } while (opcao != 3);

        }
    }
}
    

//7 - Crie uma classe chamada Música que contenha os atributos nome, autor e gravadora.
//Após, crie uma classe Playlist que possua como atributo uma Lista de músicas e uma string para armazenar o dono da playlist.
//Implemente um método para adicionar músicas na lista, para "tocar a música" (só mostrar uma mensagem na tela com o titulo da música).
//Tente fazer uma reprodução aleatória, ou seja, em vez de percorrer do inicio ao fim da lista, faça um random para acessar valores aleatórios válidos.