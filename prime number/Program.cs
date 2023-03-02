// prime number between 0-100
using System;

{
    static void Main(string[]) args)

    {
        Console.WriteLine("Prime numbers between 0 and 100:");

        for (int i = 2; i <= 100; i++)

        {
            int factors = 0;

            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)

                {
                    factors++;
                    break;

                }
            }
            Console.Write(i + " ");
        }
    }
}