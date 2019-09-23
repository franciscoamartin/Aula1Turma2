﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Usuario
    {

        public int Id { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; } = true; // tornar default todos os usuarios

        public int UsuarioCriacao { get; set; }

        public int UsuarioAlteracao { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAlteracao { get; set; }

        //public Usuario(string login, string senha)
        //{
        //    Login = login;
        //    Senha = senha;
        //}
    }
}
