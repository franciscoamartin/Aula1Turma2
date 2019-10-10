using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNomes.Model
{
    public class Nome
    {
        [Key]
        public int Id { get; set; }

        public string Nomes { get; set; }
    }
}
