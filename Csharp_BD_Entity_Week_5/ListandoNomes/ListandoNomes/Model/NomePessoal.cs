﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoNomes.Model
{
    public class NomePessoal
    {

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Origem { get; set; }
    }
}
