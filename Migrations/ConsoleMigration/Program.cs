﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMigration.Model;

namespace ConsoleMigration.Model
{
    class Program
    {

        static MigrationContext db = new MigrationContext();
        static void Main(string[] args)
        {
            db.Usuarios.ToList().ForEach(x => Console.WriteLine(x.Nome)); //inicializa nossa base de dados

            Console.ReadKey();
        }
    }
}
