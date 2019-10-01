using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Model;

namespace ListandoPessoas2.Controller
{
    public class PessoaController
    {
        private List<Pessoa> ListaPessoas { get; set; }
        /// <summary>
        /// o metodo construtor ajuda a iniciar nossa classe para utilizarmos de maneira correta as informacoes internas
        /// com isso podemos iniciar nossa lista de pessoas sem depender do usuario ou programador na parte da interface.
        /// </summary>
        public PessoaController()
        {
            //iniciamos a lista de pessoas dentro do nosso metodo construtor
            ListaPessoas = new List<Pessoa>();

            #region Lista de pessoas
            ListaPessoas.Add(new Pessoa() { Id = 1, Nome = "Spears  ", DataNascimento = DateTime.Parse("07/11/2004"), Carteira = 846.96 });
            ListaPessoas.Add(new Pessoa() { Id = 2, Nome = "Swanson  ", DataNascimento = DateTime.Parse("20/06/2003"), Carteira = 233.09 });
            ListaPessoas.Add(new Pessoa() { Id = 3, Nome = "Gay      ", DataNascimento = DateTime.Parse("03/12/2001"), Carteira = 911.92 });
            ListaPessoas.Add(new Pessoa() { Id = 4, Nome = "Gregory  ", DataNascimento = DateTime.Parse("02/01/2000"), Carteira = 469.01 });
            ListaPessoas.Add(new Pessoa() { Id = 5, Nome = "Olson    ", DataNascimento = DateTime.Parse("18/07/2001"), Carteira = 261.90 });
            ListaPessoas.Add(new Pessoa() { Id = 6, Nome = "Garza    ", DataNascimento = DateTime.Parse("01/04/2000"), Carteira = 360.41 });
            ListaPessoas.Add(new Pessoa() { Id = 7, Nome = "Sweet    ", DataNascimento = DateTime.Parse("12/03/2003"), Carteira = 312.76 });
            ListaPessoas.Add(new Pessoa() { Id = 8, Nome = "Cline    ", DataNascimento = DateTime.Parse("26/03/2002"), Carteira = 484.51 });
            ListaPessoas.Add(new Pessoa() { Id = 9, Nome = "Oliver   ", DataNascimento = DateTime.Parse("05/07/2004"), Carteira = 513.76 });
            ListaPessoas.Add(new Pessoa() { Id = 10, Nome = "Vang     ", DataNascimento = DateTime.Parse("10/07/2000"), Carteira = 271.05 });
            ListaPessoas.Add(new Pessoa() { Id = 11, Nome = "Maddox   ", DataNascimento = DateTime.Parse("29/05/2004"), Carteira = 783.97 });
            ListaPessoas.Add(new Pessoa() { Id = 12, Nome = "Garrett  ", DataNascimento = DateTime.Parse("03/06/2006"), Carteira = 154.11 });
            ListaPessoas.Add(new Pessoa() { Id = 13, Nome = "Mcintosh ", DataNascimento = DateTime.Parse("06/07/2006"), Carteira = 902.80 });
            ListaPessoas.Add(new Pessoa() { Id = 14, Nome = "Yang     ", DataNascimento = DateTime.Parse("29/04/2005"), Carteira = 550.48 });
            ListaPessoas.Add(new Pessoa() { Id = 15, Nome = "Hendricks", DataNascimento = DateTime.Parse("05/09/2003"), Carteira = 410.56 });
            ListaPessoas.Add(new Pessoa() { Id = 16, Nome = "Cain     ", DataNascimento = DateTime.Parse("12/01/2002"), Carteira = 221.13 });
            ListaPessoas.Add(new Pessoa() { Id = 17, Nome = "Blackburn", DataNascimento = DateTime.Parse("10/05/2000"), Carteira = 135.67 });
            ListaPessoas.Add(new Pessoa() { Id = 18, Nome = "Howe     ", DataNascimento = DateTime.Parse("27/09/2005"), Carteira = 360.14 });
            ListaPessoas.Add(new Pessoa() { Id = 19, Nome = "Pratt    ", DataNascimento = DateTime.Parse("18/09/2000"), Carteira = 991.83 });
            ListaPessoas.Add(new Pessoa() { Id = 20, Nome = "Sherman  ", DataNascimento = DateTime.Parse("20/02/2003"), Carteira = 667.00 });
            #endregion

        }

        /// <summary>
        /// temos uma propriedade agora que nos retorna nossa lista com essa propriedade temos a lista completa sem regras
        /// da lista de pessoas mas ao liberar somente o get não damos o acesso para alterar fora da classe lista apenas visualizacao
        /// </summary>
        public List<Pessoa> ListaDePessoasPublica
        {
            //no get podemos retornar propriedade privada e calculo de metodos quando necessario.
            get { return ListaPessoas; }
        }

        /// <summary>
        /// Metodo que retorna nossa lista de pessoas ordenadas de forma asc pelo nome de cada um
        /// </summary>
        /// <returns>Retorna o valor já ordenado de nossa lista</returns>
        public List<Pessoa> GetPessoasOrdenadasAsc()
        {
            //aqui ordenamos ela em inumerable é novo tipo dela durante a conversão
            return ListaPessoas.OrderBy(x => x.Nome).ToList<Pessoa>(); //to list para voltar ao tipo de lista de pessoas
        }

        public List<Pessoa> GetPessoasOrdenadasDescPelaDataNascimento()
        {
            return ListaPessoas.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>();
        }

        public List<Pessoa> GetPessoasOrdenadasAscCarteira(double valor)
        {

            return ListaPessoas.FindAll(x => x.Carteira > valor).OrderByDescending(x => x.Carteira).ToList<Pessoa>();
        }

        /// <summary>
        /// metodo que retorna idade menor que informado por parametro caso parametro nao informado o valor padrao é 18
        /// </summary>
        /// <param name="idade">parametro de idade</param>
        /// <returns>Retorna a lista apenas com os valores</returns>
        public List<Pessoa> GetPessoasRetornaMaioresDe18(int idade = 18)
        {
            return ListaPessoas.FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) >= idade).OrderBy(x => x.DataNascimento).ToList<Pessoa>();
        }
        /// <summary>
        /// metodo que retorna idade menor que informado por parametro caso parametro nao informado o valor padrao é 16
        /// </summary>
        /// <param name="idade">parametro de idade</param>
        /// <returns>Retorna a lista apenas com os valores</returns>
        public List<Pessoa> GetPessoasRetornamMenoresDe16(int idade = 16)
        {
            return ListaPessoas.FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) <= idade).OrderBy(x => x.DataNascimento).ToList<Pessoa>();
        }


    }
}
