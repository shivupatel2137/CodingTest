﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChkProc());
            Console.ReadLine();
        }

        static string ChkProc()
        {
            int a, b, c, d, sumA, SumB, CnD;
            a = 50; b = 30; c = 20; d = 15;
            sumA = 130; SumB = 45; CnD = 30;
            Console.WriteLine("Enter no(N) of items required for SKU");
            int id = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            string[] Ids = new string[id];
            Console.WriteLine("Enter Value for SKU Id: ");
            for (int i = 0; i < id; i++)
            {
                Ids[i] = Console.ReadLine();
            }
            foreach (string sku in Ids)
            {
               
            }
            return "Total : " + sum;
        }
    }
}