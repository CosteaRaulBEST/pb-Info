using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo_169
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int uc1, uc2, uc3;
            uc1 = n % 10;
            n = n / 10;
            uc2 = n % 10;
            n = n / 10;
            uc3 = n % 10;
            Console.WriteLine(uc1+uc2+uc3);
        }
    }
}
