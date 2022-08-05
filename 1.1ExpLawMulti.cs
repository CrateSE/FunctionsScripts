void ExLawForMulti()
{
    Console.Write("Chose how many bases you'd like: ");
    int numberofbases = Convert.ToInt32(Console.ReadLine());

    //Ordinals

    // string Ordinals = "";


    for (int counter = 0; numberofbases > counter; counter++)
    {
        int numericalrep = counter + 1;
        Console.Write("What would you like your " + numericalrep + " variable to be: "); 
        int basenum = Convert.ToInt32(Console.ReadLine());

        Console.Write("What would you like your " + numericalrep + " x exponent to be: ");
        int Xexp = Convert.ToInt32(Console.ReadLine());

        Console.Write("What would you like your " + numericalrep + " y exponent to be: ");
        int Yexp = Convert.ToInt32(Console.ReadLine());

        int finalbase = basenum * basenum;
        int finalxexp = Xexp + Xexp;
        int finalyexp = Yexp + Yexp;

        if (numberofbases - 1 == counter)
        {
            Console.Write("---------------------------" + '\n');
            Console.Write(finalbase + " x^" + finalxexp + " y^" + finalyexp);
        }

    }
}
ExLawForMulti();


