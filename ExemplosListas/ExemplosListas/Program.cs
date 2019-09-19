using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemplosListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Random rdm = new Random();

            HashSet<int> dados = new HashSet<int>(); //classe que nao deixa repetir numero.

            dados.Add(30);
            dados.Add(30);//se caso houver entrada de dados iguais, é ignorado.
            dados.Add(20);

            for (int i = 0; i < 10; i++)
            {
                int random = rdm.Next(100);
                numeros.Add(random);
                //verifica se a lista nao contem este numero gerado.
                if (!numeros.Contains(random))
                {
                    //adiciona na lista
                    numeros.Add(random);
                }
                else
                {
                    i--; //decrementa no for para poder gerar outro numero que foi repetido na lista. 
                }
            }
            Console.ReadLine();


            List<Pessoa> pessoas = new List<Pessoa>();


            Pessoa p1 = new Pessoa();
            p1.Nome = "Gabriel";
            p1.Idade = 20;
            p1.Altura = 2.01;
            p1.Genero = 'M';

            pessoas.Add(p1);

            Pessoa p2 = new Pessoa();
            p2.Nome = "maria";
            p2.Idade = 22;
            p2.Altura = 1.21;
            p2.Genero = 'F';

            pessoas.Add(p2);

            Pessoa p3 = new Pessoa();
            p3.Nome = "JOAO";
            p3.Idade = 11;
            p3.Altura = 2.21;
            p3.Genero = 'M';

            pessoas.Add(p3);

            List<Pessoa> menoresIdade = new List<Pessoa>();

            foreach (Pessoa p in pessoas)
            {
                if (p.Idade < 18)
                {
                    menoresIdade.Add(p);
                }

            }


            //lambda = principais ->> where/orderBy/FirstOrDefault

            pessoas.Where(c => c.Altura > 2 && c.Nome.ToUpper().StartsWith("E"));

            List<Pessoa> pessoasOrdenadasPorAltura = pessoas.OrderByDescending(p => p.Altura).ThenBy(c => c.Idade).ToList();
            //Delegate
            //pessoas.Where(PessoasQueNaoPodemSerPresas);



        }

    }
}
