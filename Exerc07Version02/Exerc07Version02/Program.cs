using System;

namespace Exerc07Version02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto");
            string texto = Console.ReadLine();
            int contadorA = 0;
            int contadorE = 0;
            int contadorI = 0;
            int contadorO = 0;
            int contadorU = 0;



            var tamanhoTexto = texto.Length;


            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "a")
                {
                    contadorA++;
                }
            Console.WriteLine("Quantidade de 'a' no texto " + contadorA);

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "e")
                {
                    contadorE++;

                }
            Console.WriteLine("Quantidade de 'e' no texto " + contadorE);

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "i")
                {
                    contadorI++;
                }
            Console.WriteLine("Quantidade de 'i' no texto " + contadorI);

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "o")
                {
                    contadorO++;
                }
            Console.WriteLine("Quantidade de 'o' no texto " + contadorO);

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "u")
                {
                    contadorU++;
                }
            Console.WriteLine("Quantidade de 'u' no texto " + contadorU);

            Console.ReadKey();

        }
    }
}
