using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static AlunoController aluno = new AlunoController();

        static void Main(string[] args)
        {
            aluno.MenuSistema();
            Console.ReadKey();
        }
    }
}
