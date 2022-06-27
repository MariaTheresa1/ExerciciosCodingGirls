using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8
{
    /****** Aula 08 - Herança ******/
    // 2. Locadora
    public class Cliente
    {
        public int codigo;
        public string nome;
        public int idade;
        public string endereco;
        public string telefone;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public Cliente()
        {
            List<Cliente> clientes = new List<Cliente>();
            PreencherDados(clientes);
        }
        public Cliente(int codigo, string nome, int idade, string endereco, string telefone)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        public List<Cliente> PreencherDados(List<Cliente> clientes)
        {
            Console.WriteLine("---------- CADASTRO DE  CLIENTES ----------");
            int escolha;
            do
            {
                Console.Write("Informe o código do cliente: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Informe o nome do cliente: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a idade do cliente: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Informe o endereço do cliente: ");
                string endereco = Console.ReadLine();
                Console.Write("Informe o telefone do cliente: ");
                string telefone = Console.ReadLine();

                clientes.Add(new Cliente(codigo, nome, idade, endereco, telefone));

                Console.Write("Deseja cadastrar mais um cliente?\nDigite 1 para SIM ou outro número para NÂO: ");
                escolha = int.Parse(Console.ReadLine());
            } while (escolha != 1);

            return clientes;
        }
    }
    public class Jogo
    {
        public int codigo;
        public string nome;
        public int classificacao;
        public int lancamento;
        public bool emprestado;
        public string genero;

        public Jogo()
        {
            emprestado = false;
            List<Jogo> jogos = new List<Jogo>();
            ImprimirInformacaoJogo(jogos);
        }
        public void ImprimirInformacaoJogo(List<Jogo> jogos)
        {
            Console.WriteLine("---------- LISTA DE JOGOS ----------");
            foreach (Jogo jogo in jogos)
            {
                Console.WriteLine($"Código: {jogo.codigo}");
                Console.WriteLine($"Nome: {jogo.nome}");
                Console.WriteLine($"Classificação: {jogo.classificacao} anos");
                Console.WriteLine($"Data de lançamento: {jogo.lancamento}");
                if (jogo.emprestado == true)
                    Console.WriteLine("Emprestado? Sim.");
                else
                    Console.WriteLine("Emprestado? Não.");
                Console.WriteLine($"Gênero: {jogo.genero}");
            }
        }
        public List<Jogo> LocarJogo(List<Jogo> jogos)
        {
            Console.WriteLine("Qual o código do jogo que deseja locar?");
            int codigo = int.Parse(Console.ReadLine());
            foreach (Jogo jogo in jogos)
            {
                if (codigo == jogo.codigo)
                {
                    jogo.emprestado = true;
                    Console.WriteLine("Jogo locado com sucesso.");
                    return jogos;
                }
            }
            Console.WriteLine("Jogo com o código infomado não encontrado.");
            return jogos;
        }
        public List<Jogo> DevolverJogo(List<Jogo> jogos)
        {
            Console.WriteLine("Qual o código do jogo que deseja locar?");
            int codigo = int.Parse(Console.ReadLine());
            foreach (Jogo jogo in jogos)
            {
                if (codigo == jogo.codigo)
                {
                    jogo.emprestado = false;
                    Console.WriteLine("Jogo devolvido com sucesso.");
                    return jogos;
                }
            }
            Console.WriteLine("Jogo com o código informado não encontrado.");
            return jogos;
        }
    }
    public class Locadora
    {
        public string nome;
        public Cliente clientes;
        public Jogo jogos;

        public Locadora(string nome)
        {
            this.nome = nome;

            List<Cliente> listaDeClientes = new List<Cliente>();
            listaDeClientes = clientes.PreencherDados(listaDeClientes);

            List<Jogo> listaDeJogos = new List<Jogo>();
            jogos.ImprimirInformacaoJogo(listaDeJogos);
        }


    }
    public class Emprestimo
    {
        public int codigoJogo;
        public string dataLocacao;
        public string dataDevolucao;
        public float valorLocacao;

        public Emprestimo(int codigoJogo, string dataLocacao, string dataDevolucao, float valorLocacao)
        {
            this.codigoJogo = codigoJogo;
            this.dataLocacao = dataLocacao;
            this.dataDevolucao = dataDevolucao;
            this.valorLocacao = valorLocacao;
        }
        public void RenovarEmprestimo()
        {

        }
    }

}
internal class Program
{
    static void Main(string[] args)
    {

    }
}
}
