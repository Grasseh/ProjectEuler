﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(Problem34.Solve());
            sw.Stop();
            Console.WriteLine("Problem solved in : " + sw.ElapsedMilliseconds + " milliseconds.");
            Console.ReadLine();
        }
    }
}
