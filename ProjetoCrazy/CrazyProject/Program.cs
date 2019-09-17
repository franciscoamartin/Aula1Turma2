using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCervejas();
            Console.ReadKey();
        }

        //private static void Arvore()
        //{

        //    int ascii = 65;
        //    Console.OutputEncoding = Encoding.UTF8;
        //    int numberOfRows = 20;
        //    for (int i = 1; i <= numberOfRows; i++)
        //    {
        //        int starCount = 0;
        //        for (int j = 1; j <= numberOfRows – i; j++)
        //        {
        //        Console.Write(" ");
        //    }
        //    while (2 * i – 1 != starCount)
        //        {
        //        Console.Write(Convert.ToChar(ascii + starCount));
        //        starCount++;
        //    }
        //    Console.WriteLine("");
        //}
        //Console.ReadKey();
        //}


        private static void ListaCervejas()
        {
            List<string> cervejas = new List<string> { "Skol", "Brahma", "Antarctica", "Patagonia", "Stella Artois", "Skol", "Polar" };

            foreach (var item in cervejas)
            
                Console.WriteLine(item);
           
        }

    }
}

