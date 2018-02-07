using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to see some Ray Lewis Dice Magic!");
        string stringNumber = Console.ReadLine();
        int numberMagic = int.Parse(stringNumber);

        for (int index = 0; index <= numberMagic; index++)
        {
            if (index == 52)
            {
                Console.WriteLine("Raymond Anthony Lewis, Jr.");
            }
            else if (index % 3 == 0 && index % 5 == 0)
            {
                Console.WriteLine("Ray Lewis");
            }
            else if (index % 3 == 0)
            {
                Console.WriteLine("Ray");
            }
            else if (index % 5 == 0)
            {
                Console.WriteLine("Lewis");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

    }
}
