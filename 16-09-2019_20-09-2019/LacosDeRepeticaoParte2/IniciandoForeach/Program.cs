using System;

namespace IniciandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaCarros();
        }
        /// <summary>
        /// Metodo que mostra como podemos utilizar o foreach para andar sobre uma array de caracteres, ou seja, 
        /// um texto ou paravra etc...
        /// </summary>
        private static void IniciandoForeach01()
        {
            Console.WriteLine("Informar o texto");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e') //deleta o caractere informado.
                    continue;
                Console.WriteLine(item);
            }
        }
        private static void ForeachComSplit()
        {
            var seunome = string.Empty;
            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{seunome};para;depois;usar;com;o;replacea";

            Console.WriteLine("Informe a palavra para realizar a busca: ");
            seunome = Console.ReadLine();
            //var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');//split para separar as palavras na busca

            foreach (var item in conteudoTextoSplit)
            {
                if (seunome == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo de busca com split e informando o nome
        /// </summary>
        private static void Foreach01()
        {
            Console.WriteLine("Informe o nome: ");

            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replacea";

            Console.WriteLine("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();

            //var conteudoTextoSplit = conteudoDoTexto.Replace(';', ' ');//split para separar as palavras na busca
            //Console.WriteLine(conteudoTextoSplit);
            var conteudoTextoSplit1 = conteudoDoTexto.Split(';');

            foreach (var item in conteudoTextoSplit1)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucesso!");
                //Console.Write(item);
            }
            Console.ReadKey();
        }

        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Francisco,idade:10;nome:Augusto,idade:10;nome:Martin,idade:11";
            var lista = conteudo.Split(';');

            Console.WriteLine("Usuários cadastrados no sistema: ");
            foreach (var item in lista)
            {
                Console.Write(item.Split(',')[0]);
                Console.Write(" ");
                Console.WriteLine(item.Split(',')[1]);
            }

            Console.WriteLine("Informe um nome do sistema:");
            var nomeBusca = Console.ReadLine();

            foreach (var item in lista)
            {
                var informacoesSplit = item.Split(',');
                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// metodo de busca por modelo de carro usando split
        /// </summary>
        private static void ConsultaCarros()
        {
            var conteudo = "Carro:Jetta,Marca:Ford,Ano:2000;Carro:ModelS,Marca:Tesla,Ano:2018;Carro:Uno,Marca:Fiat,Ano:2002;Carro:X30,Marca:Volvo,Ano:2009";
            var lista = conteudo.Split(';');
            var nomeBusca = string.Empty;
            Console.WriteLine("Carros disponíveis: ");

            foreach (var item in lista)
            {
                Console.WriteLine(item.Split(',')[0]);
                //Console.Write(" ");
                ////Console.WriteLine(item.Split(',')[1]);
            }
            Console.WriteLine("Informe a marca do veiculo:");
            nomeBusca = Console.ReadLine();

            foreach (var item in lista)
            {
                var informacoesSplit = item.Split(',');
                var carro = informacoesSplit[0].Split(':')[1];
                var marca = informacoesSplit[1].Split(':')[1];
                var ano = informacoesSplit[2].Split(':')[1];
                if (carro == nomeBusca)
                {
                    var anoAtual = DateTime.Now.Year;
                    var anoDoVeiculo = (anoAtual - int.Parse(ano));

                    Console.WriteLine($"O veículo da marca {marca} está com {anoDoVeiculo} anos de uso,e é do ano {ano}");
                }
            }
            Console.ReadKey();
        }
    }
}

