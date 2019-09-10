using System;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(" ");
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (a == "v" && b == a) {
                Console.WriteLine("Verdadeiro");
            } else if
                (a == "f" && b == a) {
                Console.WriteLine("Falso");
            } else if (a == b || a != b) {
                Console.WriteLine(" Verdadeiro");
            } else { 
                Console.WriteLine(" Falso");
            }

        }
    }
}

