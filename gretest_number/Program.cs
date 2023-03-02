using System;

class Program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;

        int greatest = num1;
        if (num2 > greatest)
        {
            greatest = num2;
        }
        if (num3 > greatest)
        {
            greatest = num3;
        }

        Console.WriteLine($"The greatest number is {greatest}.");
    }
}