using System;
using System.Collections.Generic;
using System.Linq;
using ListagemDeCervejas.Model;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext SistemaCervejaContext = new SistemaCervejaContext();

        //metodo para listar a cerveja
        public List<Cerveja> GetCervejas()
        {
            return SistemaCervejaContext.ListaCervejas;
        }
        //metodo cadastro de cerveja
        public void CadastrarCervejas(Cerveja cerveja)
        {
            cerveja.Id = SistemaCervejaContext.IDParam++;
            SistemaCervejaContext.ListaDeCervejas.Add(cerveja);
        }
        //metodo soma de valor das cervejas
        public double ListaSomaValor()
        {
            return SistemaCervejaContext.ListaDeCervejas.Sum(x => x.Valor);
        }

        //metodo de soma de litros de cervejas
        public double ListaSomaLitros()
        {
            return SistemaCervejaContext.ListaDeCervejas.Sum(x => x.Litros);
        }
        //metodo para calcular porcentagem
        public double CalcularPorcentagemSangue()
        {
            Console.Write("Digite seu peso: ");
            var entradaDados = double.Parse(Console.ReadLine());
            return entradaDados * 0.07;
        }
        //public bool CalcularPorcentagem(double valor)
        //{
        //    if (valor >= 0.350)
        //    return true;
            
        //}

        //public void CalcularBebeuAcima()
        //{
        //    Console.WriteLine("Vai ser preso, bebeu acima de: ");
        //    Console.WriteLine(CalcularPorcentagemSangue());

        //    }

        //    //return SistemaCervejaContext.ListaDeCervejas.Sum(x => x.Litros);
        //}
    }
}
