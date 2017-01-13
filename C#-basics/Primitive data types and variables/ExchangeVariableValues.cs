using System;
class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int firstNumber = 5;
        int secondNumber = 10;
        int current = 0;
        Console.WriteLine("Print numbers before exchange ");
        Console.WriteLine("First number: {0}, Second number: {1}", firstNumber, secondNumber);
        Console.WriteLine();
        current = firstNumber;
        firstNumber = secondNumber;
        secondNumber = current;
        Console.WriteLine("Print numbers after exchange");
        Console.WriteLine("First number: {0}, Second number: {1}", firstNumber, secondNumber);
    }
}