using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrdenacao
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public double SaldoCarteira { get; set; }

        public Pessoa(int id, string nome, DateTime dataNascimento, double saldoCarteira)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            SaldoCarteira = saldoCarteira;
        }
    }
}
