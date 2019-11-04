using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroImoveis.Model
{
    public class Controle
    {
        public bool Ativo { get; set; } = true;

        public int UsuInc { get; set; } = 0;

        public int UsuAlt { get; set; } = 0;

        public DateTime DatInc { get; set; } = DateTime.Now;

        public DateTime DatAlt { get; set; } = DateTime.Now;
    }
}
