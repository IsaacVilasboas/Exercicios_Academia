namespace Winform_Amigo
{
    public partial class Form1 : Form
    {
        List<Amigo> lista = new List<Amigo>();
        public Form1()
        {
            InitializeComponent();
            Persistencia.popularArquivoLista("amigos.csv", lista);
            colocarListaText(lista);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome;
            string email;
            nome = textBoxNome.Text;
            email = textBoxEmail.Text;

            //instanciar um objeto amigo
            Amigo amigo = new Amigo(nome, email);

            //adicionar na lista
            if (lista.Contains(amigo))
            {
                MessageBox.Show("Email já em uso!", "Alerta!");
            }
            else if (nome == "" || email == "")
            {
                MessageBox.Show("Nome ou Email não foram preenchidos", "Alerta!");
            }
            else
            {
                lista.Add(amigo);
                lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                Persistencia.gravarSimples(amigo, "amigos.csv");
            }

            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            colocarListaText(lista);
        }
        private void colocarListaText(List<Amigo> lista)
        {
            listViewAmigos.Items.Clear();
            foreach (var amigo in lista)
            {
                string[] itens = { amigo.Nome, amigo.Email };
                listViewAmigos.Items.Add(new ListViewItem(itens));
            }
        }
        private void limpar()
        {
            lista.Clear();
            listViewAmigos.Items.Clear();
            listViewSecretos.Items.Clear();
            Persistencia.ApagarArquivo("amigos.csv");
            Persistencia.ApagarArquivo("secreto.csv");
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ao limpar a tabela os pares da lista dos amigos secretos também serão apagados. Deseja apagar ?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            limpar();

        }
        //Botão para Gerar Pares Secretos
        private void button1_Click(object sender, EventArgs e)
        {
            List<Amigo> listaTmp = new List<Amigo>();
            listaTmp.AddRange(lista);

            bool deuCerto;
            do
            {
                deuCerto = true;
                listaTmp = listaTmp.OrderBy(x => Random.Shared.Next()).ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i] == listaTmp[i])
                    {
                        deuCerto = false;
                        listaTmp.Clear();
                        listaTmp.AddRange(lista);
                        break;
                    }
                }
            } while (!deuCerto);

            Persistencia.gerarArquivoAmigoSecreto(lista, listaTmp);

            listViewSecretos.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                string[] itens = { lista[i].Email, listaTmp[i].Email };
                listViewSecretos.Items.Add(new ListViewItem(itens));
            }
        }


    }
}