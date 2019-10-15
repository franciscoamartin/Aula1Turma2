using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
   public class Aluno
    {
        [Key]
        public int id { get; set; }
        //[Required] setar -- requere uma id
        //[StringLength(30)] --setar tamanho da string
        public string Nome { get; set; }

        public int Idade { get; set; }
    }
}
