using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImoveisProprietarios.Models
{
    public class Proprietarios
    {
        [Key]
        public int Id { get; set; }
        [CustomValidator("Nome")]
        public string Nome { get; set; } = string.Empty;

        //[Range(typeof(DateTime), "1/1/1870", "3/10/2000",
        //ErrorMessage = "A data {0} precisa estar entre {1} e {2}")]
        [CustomValidator("DataNascimento")]
        public DateTime DataNascimento { get; set; } = DateTime.MinValue;

        [EmailAddress]
        [CustomValidator("Email")]
        public string Email { get; set; } = string.Empty;
    }
}