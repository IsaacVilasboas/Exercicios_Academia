using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Musica
    {
        public string nome;
        public string autor;
        public string gravadora;
        

        public Musica(string nome, string autor, string gravadora)
        {
            this.nome = nome;
            this.autor = autor;
            this.gravadora = gravadora;
        }
        public static void AdicionarMusica(List<Musica> list)
        {
             Console.WriteLine("Informe o nome da música:");
             string musica = Console.ReadLine();

             Console.WriteLine("Informe o nome do autor:");
             string autor = Console.ReadLine();

             Console.WriteLine("Informe o nome da gravadora:");
             string gravadora = Console.ReadLine();
                
             Musica registrada = new Musica(musica, autor, gravadora);
             list.Add(registrada);
        }

    }
}
