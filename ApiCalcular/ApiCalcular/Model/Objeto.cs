using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCalcular.Controllers
{
    public class Objeto
    {
        [Key]
        public int Id { get; set; }

        public double Densidade { get; set; }

        public double ValorTotal { get; set; }

        public double Peso { get; set; }
    }
}
