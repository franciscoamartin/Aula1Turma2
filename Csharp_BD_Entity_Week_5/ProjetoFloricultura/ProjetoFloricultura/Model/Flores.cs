using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFloricultura.Model
{
    public class Flores
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }
    }
}
