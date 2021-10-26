using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo_2264
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int uc1, uc2;
            uc1 = n % 10;
            n = n / 10;
            uc2 = n % 10;
            Console.WriteLine( uc1 + uc2 );

        }
    }
}
