using System;
using System.Collections.Generic;
using System.Linq;

class BiggerNumbers
{
    static int GetMax(int firstNumberr, int secondNumber) 
    {
        if (firstNumberr >= secondNumber)
        {
           return firstNumberr;
        }
        else
        {
            return secondNumber;
        }
    }
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);

    }
}

