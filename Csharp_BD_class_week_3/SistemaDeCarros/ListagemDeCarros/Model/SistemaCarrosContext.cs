using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Model
{
    public class SistemaCarrosContext
    {
        public List<Carro> Carros { get; set; }

        public SistemaCarrosContext()
        {
            Carros = new List<Carro>();

            Carros.Add(new Carro { Id = 1, Marca = "BRAVADO", Modelo = "Buffalo S", Cilindradas = 2000, Ano = 2012, Portas = 2 });
            Carros.Add(new Carro { Id = 2, Marca = "ALBANY", Modelo = "Cavalcade", Cilindradas = 1000, Ano = 2012, Portas = 4 });
            Carros.Add(new Carro { Id = 3, Marca = "INVETERO", Modelo = "Coquette", Cilindradas = 1000, Ano = 2014, Portas = 2 });
            Carros.Add(new Carro { Id = 4, Marca = "GROTTI", Modelo = "Cheetah", Cilindradas = 3200, Ano = 2015, Portas = 2 });
            Carros.Add(new Carro { Id = 5, Marca = "VAPID", Modelo = "Dominator", Cilindradas = 2000, Ano = 2016, Portas = 4 });
            Carros.Add(new Carro { Id = 6, Marca = "OVERFLOD", Modelo = "Entity XF", Cilindradas = 4000, Ano = 2012, Portas = 2 });
            Carros.Add(new Carro { Id = 7, Marca = "DECLASSE", Modelo = "Sabre Turbo", Cilindradas = 2500, Ano = 2010, Portas = 4 });
            Carros.Add(new Carro { Id = 8, Marca = "UBERMACHT", Modelo = "Sentinel", Cilindradas = 1000, Ano = 2018, Portas = 4 });
            Carros.Add(new Carro { Id = 9, Marca = "DECLASSE", Modelo = "Voodoo", Cilindradas = 1500, Ano = 2011, Portas = 4 });
            Carros.Add(new Carro { Id = 10, Marca = "TRUFFADE", Modelo = "Adder", Cilindradas = 3500, Ano = 2012, Portas = 2 });

        }

        public List<Carro> ListaCarrosPublica { get { return Carros; } }
    }
}
