using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBicicleta.Model
{
    public class Usuario : ControleUsuario
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(30)]
        [Required]
        public string Login { get; set; }

        [Required]
        [MaxLength(30)]
        public string Senha { get; set; }
    }
}