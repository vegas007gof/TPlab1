using System;


namespace LR12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.4;
            double z = 5;
            double Et = 8.2;
            double t = (35 / a * z + z * a - (a + Et) / 4);
            Console.WriteLine(t);

        Console.ReadKey();
        }
    }
}