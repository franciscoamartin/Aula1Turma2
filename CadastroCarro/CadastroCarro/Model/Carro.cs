﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarro.Model
{
    class Carro
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Valor { get; set; }
        public string Placa { get; set; }

        public override string ToString()
        {
            string list = string.Empty;
            list = "Marca: " +  Marca + "Modelo: " + Modelo + "Ano: " + Ano + " Valor: " + Valor + "Placa" + Placa;
            return list;
        }
    }

    
}
