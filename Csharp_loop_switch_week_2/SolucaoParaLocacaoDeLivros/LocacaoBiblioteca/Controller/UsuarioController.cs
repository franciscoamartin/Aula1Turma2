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
        //private LocacaoContext contexDB = new LocacaoContext();
        BibliotecaContextDB contextDB = new BibliotecaContextDB();

        //criando privado para impedir o programador de adicionar um ID ou alterar fora da classe.


        public UsuarioController()
        {
            var defaultUser = contextDB.Usuario.FirstOrDefault(x =>
            x.Login == "admin" && x.Senha == "admin" && x.Ativo ==  true);

            if (defaultUser == null)
                contextDB.Usuario.Add(new Usuario()
                {
                    Login = "admin",
                    Senha = "admin"
                });
            contextDB.SaveChanges();
        }

        public bool AtualizarUsuario(Usuario item)
        {
            var usuario = contextDB.Usuario.FirstOrDefault(x => x.Id == item.Id); //buscando na tabela o celular e regra para realizar a busca
            if (usuario == null)//falamos que nosso celular da tabela vai ser igual nosso celular que estamos passando, e verificamos se ele realmente encontrou um celular
            {
                return false; //caso nao encontramos retornando false
            }
            else
            {
                // nosso celular da tabela vai ser igual nosso celular que estamos passando
                usuario.DataAlteracao = DateTime.Now;
                contextDB.SaveChanges();
            }
            return true; //retornando a atualizacao
        }

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
            bool login = GetUsuario().ToList().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
            return login;
        }


        public IQueryable<Usuario> GetUsuario()
        {
            return contextDB.Usuario.Where(x => x.Ativo == true); //acesso ao BD com filtro where e as condicoes
        }


        /// <summary>
        /// metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name="parametroUsuario">novo usuario que sera adicionardo a lista</param>
        public bool AdicionarUsuario(Usuario parametroUsuario) { 
        //{
        //    //adiciono o meu usuario a minha lista.
        //    contexDB.ListaDeUsuarios.Add(parametroUsuario);
        //    parametroUsuario.DataCriacao = DateTime.Now;
        //    parametroUsuario.Id = contexDB.IdContadorUsuarios++;
         if (string.IsNullOrWhiteSpace(parametroUsuario.Login)) //nosso tipo contem varios metodos prontos para string e metodo que identifica espacos em branco e campo que vai validar
                return false;
            if (string.IsNullOrWhiteSpace(parametroUsuario.Senha)) //nosso tipo contem varios metodos prontos para string e metodo que identifica espacos em branco e campo que vai validar
                return false;

            contextDB.Usuario.Add(parametroUsuario);
            contextDB.SaveChanges();
            return true;
        }

        //// metodo default para todos os usuários para ativo.
        // public List<Usuario> RetornaListaDeUsuarios()
        // {
        //     return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
        // }

        // /// <summary>
        // /// metodo que desativa um registro de usuario cadastrado em nossa lista
        // /// </summary>
        // /// <param name="identification">parametro que identifica o usuario que sera desativado</param>
        // public void RemoverUsuario(int identification)
        // {
        //     //aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista com isso
        //     //conseguimos acessar as propriedades dele e desativar o registro.
        //     contexDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identification).Ativo = false;
        //     Console.WriteLine("Usuário Desativado com sucesso");
        // }

        public void RemoverUsuario(int identification)
        {
            var usuario = contextDB.Usuario.FirstOrDefault(x => x.Id == identification);
            //tratamento de valores inválidos.
            if (usuario != null)
            {
                usuario.Ativo = false;
                contextDB.SaveChanges();//salva no BD

                Console.WriteLine("Usuario removido com sucesso");
            }
            //Console.WriteLine("Digite um valor valido");
        }

    }



}
