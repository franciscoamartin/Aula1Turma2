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

            var letraA = texto.Length;


            for (int i = 0; i < letraA; i++)
                if(texto[i].ToString() == "a")
                {
                    contadorA++;
                    Console.WriteLine("Quantidade de " + contadorA);
                }

            for (int i = 0; i < letraA; i++)
                if (texto[i].ToString() == "a")
                {
                    contadorE++;
                    Console.WriteLine("Quantidade de " + contadorE);
                }
            for (int i = 0; i < letraA; i++)
                if (texto[i].ToString() == "a")
                {
                    contadorI++;
                    Console.WriteLine("Quantidade de " + contadorI);
                }

                    Console.ReadKey();

        }
    }
}
