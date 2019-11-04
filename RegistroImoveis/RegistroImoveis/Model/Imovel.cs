using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroImoveis.Model
{
    public class Imovel : Controle
    {
        [Key]
        public int Id { get; set; }

        public string NomeImovel { get; set; }
    }
}
