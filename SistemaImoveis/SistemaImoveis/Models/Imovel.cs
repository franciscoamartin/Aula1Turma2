using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaImoveis.Models
{
    public class Imovel 
    {
        public int Id { get; set; }
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public int ProprietarioId { get; set; }

        public int Teste { get; set; }


    }
}