﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second ");
            double b = Convert.ToDouble(Console.ReadLine());
            double resAdd = a + b;
            Console.WriteLine("Result addition = " + resAdd);
            double resSub = a - b;
            Console.WriteLine("Result subtraction = " + resSub);
            double mySin = Math.Sin(a);
            Console.WriteLine("Result Sin = " + mySin);
            double myCos = Math.Cos(a);
            Console.WriteLine("Result Cos = " + myCos);
            Console.ReadKey();
        }
    }
}
