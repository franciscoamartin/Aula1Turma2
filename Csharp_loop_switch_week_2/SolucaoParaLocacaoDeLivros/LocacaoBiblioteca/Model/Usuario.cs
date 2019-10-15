using System;
using System.ComponentModel.DataAnnotations;

namespace LocacaoBiblioteca.Model
{
    public class Usuario : ControleUsuario
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Login { get; set; } 

        [Required]
        [MaxLength(30)]
        public string Senha { get; set; }

        //public bool Ativo { get; set; } = true; // tornar default todos os usuarios

        //public int UsuarioCriacao { get; set; } = 0;

        //public int UsuarioAlteracao { get; set; } = 0;

        //public DateTime DataCriacao { get; set; } = DateTime.Now;

        //public DateTime DataAlteracao { get; set; } = DateTime.Now;

    }
}
