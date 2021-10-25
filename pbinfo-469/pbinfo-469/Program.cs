
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbinfo_469
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if ((n >= a) && (n <= b))
            {
                Console.WriteLine("DA");
            }
           else  Console.WriteLine("NU");
        }
    }
}
