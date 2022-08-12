using System;

namespace ZeroExp
{
    public static void Main(string[] args)
    {
        static void ZeroExp()
        {
            Console.WriteLine("What is your base?: ");
            double var = Convert.ToDouble(Console.ReadLine());

            double finans = 0;
            if (finans == 0)
            {
                finans = 1;
            }

            Console.Write("The result is: {0}^(0) = {1}", var, finans);
        }
        ZeroExp();
    }
}
