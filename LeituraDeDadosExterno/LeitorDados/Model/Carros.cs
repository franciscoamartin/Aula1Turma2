using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorDados.Model
{
    public class Carros
    {
        public int Id { get; set; }
        public string Carro { get; set; }
        public double Valor { get; set; }

        public int Quantidade { get; set; }

        public DateTime Data { get; set; }

        public Carros(int id, string carro, double valor, int quantidade, DateTime data)
        {
            Id = id;
            Carro = carro;
            Valor = valor;
            Quantidade = quantidade;
            Data = data;
        }
    }

}
