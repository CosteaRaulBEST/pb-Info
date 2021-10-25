using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo_452
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            if (n % 10 % 2 == 1)
            {
                s = s + 1;
            }
            n = n / 10;
            if (n % 10 % 2 == 1)
            {
                s = s + 1;
            }
            n = n / 10;
            if (n % 10 % 2 == 1)
            {
                s = s + 1;
            }
            Console.WriteLine(s);
        }
    }
}
