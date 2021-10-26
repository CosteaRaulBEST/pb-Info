using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo_468
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int uc1 , uc2 , p ;
            uc1 = n % 10;
            n = n / 100;
            uc2 = n % 10;
            p = 10 * uc2 + uc1;
            Console.WriteLine( p * p );
        }
    }
}
