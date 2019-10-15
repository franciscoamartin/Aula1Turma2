using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            listaPessoas.Add(new Pessoa(1, "Spears", DateTime.Parse("07/11/2001"), 846.96));
            listaPessoas.Add(new Pessoa(2, "Swanson	", DateTime.Parse("07/11/2001"), 846.96));
            listaPessoas.Add(new Pessoa(3, "Gay", DateTime.Parse("07/11/2001"), 846.96));
            listaPessoas.Add(new Pessoa(4, "Gregory", DateTime.Parse("07/11/2002"), 846.96));
            listaPessoas.Add(new Pessoa(5, "Olson", DateTime.Parse("07/10/2018"), 846.96));
            listaPessoas.Add(new Pessoa(6, "Sweet", DateTime.Parse("07/01/2017"), 146.96));
            listaPessoas.Add(new Pessoa(7, "Spears", DateTime.Parse("07/01/2001"), 346.96));
            listaPessoas.Add(new Pessoa(8, "Cline", DateTime.Parse("08/11/2001"), 86.96));
            listaPessoas.Add(new Pessoa(9, "Oliver", DateTime.Parse("09/11/2000"), 46.96));
            listaPessoas.Add(new Pessoa(10, "Vang", DateTime.Parse("02/11/1991"), 146.96));
            listaPessoas.Add(new Pessoa(11, "Maddox	", DateTime.Parse("01/11/2001"), 546.96));
            listaPessoas.Add(new Pessoa(12, "Garrett", DateTime.Parse("10/11/2001"), 646.96));
            listaPessoas.Add(new Pessoa(13, "Mcintosh", DateTime.Parse("17/11/1991"), 546.96));
            listaPessoas.Add(new Pessoa(14, "Yang", DateTime.Parse("27/11/1990"), 86.96));
            listaPessoas.Add(new Pessoa(15, "Hendricks", DateTime.Parse("17/11/2001"), 816.96));
            listaPessoas.Add(new Pessoa(16, "Cain", DateTime.Parse("17/11/2001"), 946.96));
            listaPessoas.Add(new Pessoa(17, "Blackburn", DateTime.Parse("30/11/2001"), 6.96));
            listaPessoas.Add(new Pessoa(18, "Howe", DateTime.Parse("22/11/2001"), 146.96));
            listaPessoas.Add(new Pessoa(19, "Pratt", DateTime.Parse("17/11/2001"), 746.96));
            listaPessoas.Add(new Pessoa(20, "Sherman", DateTime.Parse("07/11/2001"), 946.96));
            Console.WriteLine();

            Console.WriteLine("--------Exercicio Nome Crescente-------------");

            listaPessoas.
                            OrderBy(x => x.Nome).ToList<Pessoa>().
                            ForEach(i =>
                            Console.WriteLine($"Id: {i.Id} Nome: {i.Nome}"));
            Console.WriteLine();

            Console.WriteLine("--------Exercicio Nascimento Descrecente-------------");

            listaPessoas.
              OrderByDescending(x => x.DataNascimento).ToList<Pessoa>().
              ForEach(i =>
              Console.WriteLine($"Id:{i.Id} Nome: {i.Nome} Nascimento: {i.DataNascimento}"));
            Console.WriteLine();

            Console.WriteLine("--------Exercicio Pessoas com mais de 500 reais-------------");

            var listaSaldo = listaPessoas
                .Where(x => x.SaldoCarteira > 500)
                .OrderBy(x => x.Nome);
            listaSaldo.ToList<Pessoa>()
                           .ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Saldo: {i.SaldoCarteira}"));
            Console.WriteLine();

            Console.WriteLine("--------Exercicio Pessoas com mais de 18 anos-------------");
            // int idade = DateTime.Now.Year - dataNasc.Year;

            foreach (var item in listaPessoas)
            {
                var idade = DateTime.Now.Year - item.DataNascimento.Year;
                if (idade >= 18)
                {
                    Console.WriteLine($"Id {item.Id} Nome {item.Nome} Nascimento: {item.DataNascimento} Maiores de 18");

                }
                //var mostrandoMaiores = listaPessoas.FindAll(x => idade > 18);
                //Console.WriteLine($"Id {item.Id} Nome {item.Nome} Nascimento: {item.DataNascimento} Maiores de 18");
            }

            //var mostrandoMaiores = listaPessoas.
            //    Find(x => idade > 18);
            //    Console.WriteLine($"Id {item.Id} Nome {item.Nome} Maiores de 18");
            Console.WriteLine();
            Console.WriteLine("--------Exercicio Pessoas com menos de 16 anos-------------");

            foreach (var item in listaPessoas)
            {
                var idade1 = DateTime.Now.Year - item.DataNascimento.Year;
                if (idade1 <= 16)
                {
                    Console.WriteLine($"Id {item.Id} Nome {item.Nome} Nascimento: {item.DataNascimento} Maiores de 18");
                }
                //var mostrandoMaiores = listaPessoas.FindAll(x => idade1 < 16);
                //Console.WriteLine($"Id {item.Id} Nome {item.Nome} Nascimento: {item.DataNascimento} Maiores de 18");
            }

            Console.ReadKey();
        }
    }
}
