using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    internal class Playlist 
    {
        public string donoPlayList;
        

        public Playlist(string dono)
        {
            this.donoPlayList = dono;
        }
        
        public static void PlayMusic(List<Musica> list)
        {
            Random random = new Random();
            int posicao = random.Next(0, list.Count);
            Musica musica = list[posicao];
            Console.WriteLine("Tocando música: " + musica.nome + " Autor: " + musica.autor);
            
        }

    }
}
