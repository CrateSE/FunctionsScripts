using System;

namespace ExpLawDiv
{
    public static void Main(string[] args)
    {
        static void ExpLawDiv()
        {
            Console.WriteLine("What is your base?: ");
            double var = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the first exponent you'd like to subtract?: ");
            double exp1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the second exponent you'd like to subtract?: ");
            double exp2 = Convert.ToDouble(Console.ReadLine());

            double finexp = exp1 - exp2;

            if (exp1 < exp2)
            {
                finexp = exp2 - exp1; //Check so see if works and always returns a positive
            }
            else
            {
                finexp = exp1 - exp2;
            }

            double finans = Math.Pow(var, finexp);

            Console.Write("The result is: {0}^({1} - {2}) = {3}" + '\n' + "{0}^{3} = {4}", var, exp1, exp2, finexp, finans);
        }
        ExpLawDiv();
    }
}