using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;
using System.Globalization;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos nossa caixa de ferramenta de pessoas
            //podemos listar e demais funcionalidades. 
            PessoaController pessoaController = new PessoaController();
            MostraIdentificador("Lista Completa ");

            pessoaController.ListaDePessoasPublica.ForEach(i => MostraInformacoes(i));

            MostraIdentificador("Lista Ordenada por nome");
            pessoaController.GetPessoasOrdenadasAsc().ForEach(x => MostraInformacoes(x));

            MostraIdentificador("Lista Ordenada por data");
            pessoaController.GetPessoasOrdenadasDescPelaDataNascimento().ForEach(x => MostraInformacoes(x));

            MostraIdentificador("Lista Ordenada por Carteira");
            pessoaController.GetPessoasOrdenadasAscCarteira(500).ForEach(x => MostraInformacoes(x));

            MostraIdentificador("Lista ordenada pessoas acima de? ");
            MostraIdentificador("Digite a idade que você quer filtrar:");
            pessoaController.GetPessoasRetornaMaioresDe18(int.Parse(Console.ReadLine())).ForEach(x => MostraInformacoes(x));

            MostraIdentificador($"Lista Ordenada Pessoas menores de {16}");
            pessoaController.GetPessoasRetornamMenoresDe16().ForEach(x => MostraInformacoes(x));


            Console.ReadKey();
        }

        /// <summary>
        /// Metodo que mostra no console formatado nosso objeto Pessoa
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa que vamos apresentar</param>
        private static void MostraInformacoes(Pessoa pessoa)
        {
            //nosso template que apresenta as informacoes em CSS
            string template = "Id: {0,3} Nome: {1,10} Data Nascimento: {2,8} Carteira: {3,6}";
            string textoFormatado = string.Format(template, pessoa.Id, pessoa.Nome, pessoa.DataNascimento.ToString("dd/MM/yyyy"), pessoa.Carteira.ToString("C"));
            Console.WriteLine(textoFormatado);
            //Console.WriteLine(
            //      $"ID: {pessoa.Id}" +
            //      $" Nome: {pessoa.Nome}" +
            //      $" Data Nascimento: {pessoa.DataNascimento.ToShortDateString()}" +
            //      $" Carteira: {pessoa.Carteira.ToString("N2")}");
        }

        /// <summary>
        /// Metodo para mostrar a informacao inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao">identificador da lista</param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("----{0,20}----", nomeAcao));
            Console.WriteLine();

        }
    }



}
