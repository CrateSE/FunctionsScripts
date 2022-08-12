using System;

namespace ExpLawPowerLaw
{
    public static void Main(string[] args)
    {
        static void ExpLawPowerLaw()
        {
            Console.WriteLine("What is your base?: ");
            double var = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the first exponent you'd like to multiply?: ");
            double exp1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the second exponent you'd like to multiply?: ");
            double exp2 = Convert.ToDouble(Console.ReadLine());

            double finexp = exp1 * exp2;

            double finans = Math.Pow(var, finexp);

            Console.Write("The result is: {0}^({1} * {2}) = {3}" + '\n' + "{0}^{3} = {4}", var, exp1, exp2, finexp, finans);
        }
        ExpLawPowerLaw();
    }
}
