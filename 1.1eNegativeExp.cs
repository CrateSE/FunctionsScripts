using System;

namespace NegativeExp
{
    public static void Main(string[] args)
    {
        static void NegativeExp()
        {
            Console.WriteLine("What is your base?: ");
            double basevar = Convert.ToDouble(Console.ReadLine());

            //Note the order you put in your exponents does not affect which is operated on, in turn producing a negative number.

            Console.WriteLine("What is the first exponent you'd like to subtract?: ");
            double exp1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the second exponent you'd like to subtract?: ");
            double exp2 = Convert.ToDouble(Console.ReadLine());

            double finexp = exp1 - exp2;
            double finans = Math.Pow(basevar, finexp);

            if (exp2 < exp1)
            {
                finexp = exp2 - exp1;
                Console.Write("The result is: {0}^({1} - {2}) = {3}" + '\n' + "{0}^({3}) = {4}", basevar, exp2, exp1, finexp, finans);
            }
            else
            {
                finexp = exp1 - exp2;
                Console.Write("The result is: {0}^({1} - {2}) = {3}" + '\n' + "{0}^({3}) = {4}", basevar, exp1, exp2, finexp, finans);
            }
        }
        NegativeExp();
    }
}
