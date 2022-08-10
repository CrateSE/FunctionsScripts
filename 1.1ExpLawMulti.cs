//ExLawForMulti just to do calculations and return the answers.
static void Splicer(int numbas, string term)
{

    for (int counter = 0; counter < numbas; counter++)
    {
        //Term divider. Seperates each character into placements of an array.
        char[] ch = new char[term.Length];
        //This for-loop splices each character into an addressable variable.
        for (int i = 0; i < term.Length; i++)
        {
            ch[i] = term[i];
            //Breaks terms to exponent and creates addressable exponential number.
            if (ch[i] == '^')
            {
                int realnum = Convert.ToInt32(ch[i - 2]);
                int exponent = Convert.ToInt32(ch[i + 1]);
                char charactervar = Convert.ToChar(ch[i - 1]);
                Console.WriteLine(realnum);
                Console.WriteLine(exponent);
                Console.WriteLine(charactervar);
            }
        }
    }

}
static void calculations(int realnum, int exponent, int charactervar)
{

}
static void Main()
{
    string? term = "";
    Console.WriteLine("How many terms would you like?: ");
    int numbas = Convert.ToInt32(Console.ReadLine());

    for (int x = 0; x < numbas; x++)
    {
        Console.WriteLine("What is your current term?: ");
        term = Console.ReadLine();
    }


    Splicer(numbas, term);

}
Main();