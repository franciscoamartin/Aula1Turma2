using System;
using System.Collections.Generic;
using LocacaoBiblioteca.Model;


namespace LocacaoBiblioteca.Controller

    
{
    /// <summary>
    /// Classe que contem os metodos de usuarios do sistema
    /// </summary>
    public class UsuarioController

    {
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

            return Usuario.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
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
            Usuario = new List<Usuario>();

            Usuario.Add(new Usuario
            {
                Login = "Admin",
                Senha = "Admin"
            });

            Usuario.Add(new Usuario
            {
                Login = "Maria",
                Senha = "321"
            });

           
        }
        public List<Usuario> Usuario { get; set; }
    }
}
