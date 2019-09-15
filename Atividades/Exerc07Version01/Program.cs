using System;

namespace Exerc07Version01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto:");
            string texto = Console.ReadLine();
            int contadorA = 0;
            int contadorE = 0;
            int contadorI = 0;
            int contadorO = 0;
            int contadorU = 0;

            var tamanhoTexto = texto.Length;

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "a" || texto[i].ToString() == "A")
                {
                    contadorA++;
                }
            Console.WriteLine("Quantidade de letras 'a' no texto é: " + contadorA);

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "e" || texto[i].ToString() == "E")
                {
                    contadorE++;
                }
            Console.WriteLine("Quantidade de letras 'e' no texto é: " + contadorE);

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "i" || texto[i].ToString() == "I")
                {
                    contadorI++;
                }
            Console.WriteLine("Quantidade de letras 'i' no texto é: " + contadorI);

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "o" || texto[i].ToString() == "O")
                {
                    contadorO++;
                }
            Console.WriteLine("Quantidade de letras 'o' no texto é: " + contadorO);

            for (int i = 0; i < tamanhoTexto; i++)
                if (texto[i].ToString() == "u" || texto[i].ToString() == "U")
                {
                    contadorU++;
                }
            Console.WriteLine("Quantidade de letras 'u' no texto é: " + contadorU);

            Console.ReadKey();

        }
    }
}
