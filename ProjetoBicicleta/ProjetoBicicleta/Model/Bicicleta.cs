using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBicicleta.Model
{
    public class Bicicleta : ControleUsuario
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        public string Modelo { get; set; }
        [Required]
        [MaxLength(20)]
        public string Marca { get; set; }

        public double Valor { get; set; }
    }
}
