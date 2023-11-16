using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Winform_Amigo
{
    internal class Persistencia
    {
        public static void gravarSimples(Amigo a, string nomeArquivo)
        {
            try
            {
                    StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                    escritor.WriteLine(a.Nome + ";" + a.Email);

                    escritor.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo");
            }

        }
        public static void popularArquivoLista(string nomeArquivo, List<Amigo> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                while (!leitor.EndOfStream)
                {
                    string linha;
                    linha = leitor.ReadLine();
                    if (!string.IsNullOrEmpty(linha))
                    {

                        string[] vetorLinha;
                        Amigo tmp;
                        vetorLinha = linha.Split(";");
                        tmp = new Amigo(vetorLinha[0], vetorLinha[1]);
                        if (!lista.Contains(tmp))
                        {
                            lista.Add(tmp);
                        }
                    }
                }
                leitor.Close();
                lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo");
            }
        }
        public static void ApagarArquivo(string nomeArquivo)
        {
            try
            {
             
                    StreamWriter escritor = new StreamWriter(nomeArquivo, append: false);

                    escritor.WriteLine("");

                    escritor.Close();
    
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com  arquivo");
            }

        }
        public static void gerarArquivoAmigoSecreto(List<Amigo> lista, List<Amigo> listaTmp)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("secreto.csv");

                if (lista.Count < 2)
                {
                    MessageBox.Show("Para gerar o amigo secreto precisa ter ao menso duas pessoas cadastrada");
                }
                else
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        escritor.WriteLine(lista[i].Nome + ";" + lista[i].Email + ";" + listaTmp[i].Nome + ";" + listaTmp[i].Email);
                    }

                }
                escritor.Close();
                MessageBox.Show("Pares gerados com sucesso!!","Sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com arquivo");
            }
            
        }
    }
}
