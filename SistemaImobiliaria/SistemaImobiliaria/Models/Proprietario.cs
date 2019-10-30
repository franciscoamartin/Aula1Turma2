using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaImobiliaria.Models
{
    public class Proprietario
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public string DataNascimento { get; set; }

        public string Email { get; set; }
    }
}

