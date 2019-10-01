using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoas.Model;
using System.Globalization;

namespace CadastroPessoas
{
    class Program
    {
        static List<Pessoa> pessoa = new List<Pessoa>();

        static void Main(string[] args)
        {

            Cadastro();
            while (Continuar() == 1)
            {
                Cadastro();

            }
            
            Environment.Exit(0);
            Console.ReadKey();
        }

        private static int Continuar()
        {
            Console.WriteLine("Cadastrar mais pessoas ? (1)SIM(2)NÃO");
            return int.Parse(Console.ReadKey().KeyChar.ToString());
        }

        private static void Cadastro()
        {
            Pessoa list = new Pessoa();

            Console.WriteLine("Cadastro de Pessoas");
            Console.WriteLine();
            Console.Write("Digite o nome:");
            var name = Console.ReadLine();

            Console.Write("Digite o idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o gênero:");
            char genero = char.Parse(Console.ReadLine());

            Console.Write("Digite o altura:");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o CPF:");
            int cpf = int.Parse(Console.ReadLine());
            while (cpf < 11)
            {
                Console.WriteLine("Digite um CPF válido");

                cpf = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o RG:");
            int rg = int.Parse(Console.ReadLine());

            pessoa.Add(new Pessoa
            {

                Name = name,
                Age = idade,
                Gender = genero,
                Altura = altura,
                Rg = rg,
                Cpf = cpf

            });

            pessoa.ForEach(i => Console.WriteLine($"Nome: {i.Name}" +
                $" - Idade: {i.Age}" +
                $" - Gênero: {i.Gender}" +
                $" - Altura: {i.Altura.ToString("F2", CultureInfo.InvariantCulture)}" +
                $" - RG: {i.Rg}" +
                $" - CPF: {i.Cpf}"));

        }
    }
}
