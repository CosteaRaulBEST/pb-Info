using System;

namespace pbinfo_102
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cz, cu;
            cu = n % 10;
            n = n / 10;
            cz = n % 10;
            Console.WriteLine(cz+cu);

        }
    }
}
