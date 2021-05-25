//if-else example

using System;
class ifText
{
    static void Main()
    {
        Console.WriteLine("Enter a character");
        char c = (char)Console.Read()
            if (char.IsLetter(c))
        {
            if (Char.IsLower(c))
            {
                Console.WriteLine("The charter is in lower case.");

            }
            else
            {
                Console.WriteLine("The charcter is uppercase.");
            }
        }
        else
        {
            Console.WriteLine("The charecter is not in alfabetic chrecter");
        }
    }
}
