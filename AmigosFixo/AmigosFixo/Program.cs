using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigosFixo.Model;

namespace AmigosFixo
{
    class Program
    {
        static void Main(string[] args)
        {
            var meusAmigos = new List<Amigos>();

            meusAmigos.Add(new Amigos {
                Name = "Joao",
                Time = 200
                });

            meusAmigos.Add(new Amigos
            {
                Name = "Maria",
                Time = 500
            });
            meusAmigos.Add(new Amigos
            {
                Name = "José",
                Time = 300
            });


            meusAmigos.ForEach(i => Console.WriteLine($" {i.Name} é meu amigo por {i.Time} dias. "));
            Console.ReadKey();
        }
    }
}
