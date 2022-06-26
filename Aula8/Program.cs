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

        public Cliente(int codigo, string nome, int idade, string endereco, string telefone)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.telefone = telefone;
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

        public void ImprimirInformacaoJogo()
        {

        }
        public void LocarJogo()
        {

        }
        public void DevolverJogo()
        {

        }
    }
    public class Locadora
    {
        public string nome;
        public Cliente clientes;
        public Jogo jogos;
    }
    public class Emprestimo
    {
        public int codigoJogo;
        public string dataLocacao;
        public string dataDevolucao;
        public float valorLocacao;

        public Emprestimo(int codigoJogo, string dataLocacao, string dataDevolucao, float valorLocacao){
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
