using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Pessoa
    {
        [Key] //anotacao que indica que nossa chave é o campo logo a baixo da nossa anotacao e a 
        //palavra chave [key] significa que ele é nossa chave primaria
        public int Id { get; set; }

        public string Nome { get; set; }

        
    }
}
