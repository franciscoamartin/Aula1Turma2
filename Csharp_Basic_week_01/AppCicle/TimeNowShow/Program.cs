﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeNowShow
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Hora e dia atual: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")}");
                Thread.Sleep(100);
            }
        }
    }
}
