using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class AgendaTelefonica
    {
        public string nome;
        public string telefone;
        public string email;

        public AgendaTelefonica(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
        
        List<AgendaTelefonica> agenda = new List<AgendaTelefonica>();

        public void Armazenar()
        {
         string   nome = this.nome;
         string   telefone = this.telefone;
         string  email = this.email;
        }
    }
}
//Crie uma classe AgendaTelefônica com atributos para armazenar contatos (nome, telefone, e-mail).
//Implemente um construtor e métodos para adicionar numa lista, remover e buscar contatos.