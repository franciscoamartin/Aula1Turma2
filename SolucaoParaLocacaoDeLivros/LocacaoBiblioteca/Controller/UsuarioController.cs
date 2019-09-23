using System;
using System.Collections.Generic;
using System.Linq;
using LocacaoBiblioteca.Model;


namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuarios do sistema
    /// </summary>  
    /// 

    public class UsuarioController

    {
        //criando privado para impedir o programador de adicionar um ID ou alterar fora da classe.
        private int IdCount = 1;

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// para realizar o login padrão use:
        /// Login: Admin
        /// Senha: Admin
        /// </summary>
        /// <param name="login">Passamsos um objeto de nome usuario como parametro</param>
        /// <returns>Retorna verdadeiro quando existir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {

            return RetornaListaDeUsuarios().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }

        //private bool Validacao()
        //{
        //    foreach (var item in Usuario)
        //    {
        //        if (item.Contains("aa") == true) { }
        //    }
        //    return true;
        //}

        public UsuarioController()
        {
            UsuarioLista = new List<Usuario>();

            UsuarioLista.Add(new Usuario
            {
                Id = IdCount++, // adiciono o id contador incrementando o mesmo com ele +1
                Login = "admin",
                Senha = "admin",
            });

        }
        private List<Usuario> UsuarioLista { get; set; }

        /// <summary>
        /// metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name="parametroUsuario">novo usuario que sera adicionardo a lista</param>
        public void AdicionarUsuario(Usuario parametroUsuario)
        {
            //adiciono o meu usuario a minha lista.
            UsuarioLista.Add(parametroUsuario);
            parametroUsuario.DataCriacao = DateTime.Now;
            parametroUsuario.Id = IdCount++;
        }

        //metodo default para todos os usuários para ativo.
        public List<Usuario> RetornaListaDeUsuarios()
        {
            return UsuarioLista.Where(x => x.Ativo).ToList<Usuario>();
        }

        /// <summary>
        /// metodo que desativa um registro de usuario cadastrado em nossa lista
        /// </summary>
        /// <param name="identification">parametro que identifica o usuario que sera desativado</param>
        public void RemoverUsuario(int identification)
        {
            //aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista com isso
            //conseguimos acessar as propriedades dele e desativar o registro.
            UsuarioLista.FirstOrDefault(x => x.Id == identification).Ativo = false;
            Console.WriteLine("Usuário Desativado com sucesso");

        }
    }
}
