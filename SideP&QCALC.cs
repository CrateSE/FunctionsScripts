using System;

namespace P_QCALC
{
    public static void Main(string[] args)
    {
        static void P_QCALC()
        {
 int function_degree = 0;
 Console.WriteLine("What degree is your function: ");
 function_degree = Convert.ToInt32(Console.ReadLine());

 for (int h = 0; h <= function_degree; h++)
 {
int [] array_numbs = 0;
Console.WriteLine("Input coefficient of the" + h + "term");
int coefficient = Convert.ToInt32(Console.ReadLine());

array_numbs = [array_numbs[coefficient] + " "];
 }
        }
        P_QCALC();
    }
}
