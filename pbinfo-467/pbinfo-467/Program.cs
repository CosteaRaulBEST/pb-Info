using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo_467
{
    class Program
    {
        static void Main(string[] args)
        {
            int uc1, uc2; 
            int n = int.Parse(Console.ReadLine());
            uc1 = n % 10;
            n = n / 100;
            uc2 = n % 10;
            Console.WriteLine( uc1 * uc2);
        }
    }
}
