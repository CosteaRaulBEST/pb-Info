using System;

namespace pbinfo_2263
{
    class Program
    {
        static void Main(string[] args)
        {

            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(t1*m*z+t2*n*z);

        }
    }
}
