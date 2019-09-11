using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray {
    class Program {
        static void Main(string[] args) {

            string[] arrayLinear = new string[3];

            arrayLinear[0] = "Array1";
            arrayLinear[1] = "Array2";

            List<string> listaLinear = new List<string> {
                "List1",
                "List2",
                "List3"
            };

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listaLinear[0]);

            var keyPress = Console.ReadKey().KeyChar.ToString();
        }
    }
}
