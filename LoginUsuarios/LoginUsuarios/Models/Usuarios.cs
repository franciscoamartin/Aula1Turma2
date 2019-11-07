using System;
using System.Collections.Generic;

namespace LoginUsuarios.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
