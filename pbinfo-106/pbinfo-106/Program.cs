﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo_106
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if ((a <= b) && (a <= c))
            {
                Console.WriteLine(a);
            }
            else if ((b <= a) && (b <= c))
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }


        }
    }
}
