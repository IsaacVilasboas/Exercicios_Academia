using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class CorretoraDeImoveis
    {
        public string endereço;
        public string preço;
        public string tipo;

        public CorretoraDeImoveis(string endereço, string preço, string tipo)
        {
            this.endereço = endereço;
            this.preço = preço;
            this.tipo = tipo;
        }
        private List<CorretoraDeImoveis>RegistoImoveis = new List<CorretoraDeImoveis>();
        public void AdcImoveis()
        {
            Console.WriteLine("Adicionar Imovel");
            Console.WriteLine("Endereço do imovel ?");
            this.endereço = Console.ReadLine();
            Console.WriteLine("Preço do imovel?");
            this.preço = Console.ReadLine();
            Console.WriteLine("Qual o tipo");
            this.tipo = Console.ReadLine();

            CorretoraDeImoveis r = new CorretoraDeImoveis(endereço, preço, tipo);


            RegistoImoveis.Add(r);
        }
        public void Alterador()
        {
            Console.WriteLine("Deseja alterar o valor de algum imovel ?");
            string rep = Console.ReadLine().ToLower();
            if (rep == "sim")
            {
                Console.WriteLine("Qual o novo preço ?");
                this.preço = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("nenhuma mudança efeutada");
            }
        }
        public void ValorMedio()
        {
            int cont = 0;
            double media = 0;
            
            media = cont / media;
        }
    }
}

//Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre imóveis (endereço, preço, tipo).
//Implemente um construtor e métodos para listar imóveis disponíveis e calcular o valor médio.
//Crie um menu que contenha as opções de inserir imoveis, alterar preço do imovel e apresentar todos os imoveis. Insira os imoveis numa lista para facilitar o trabalho.