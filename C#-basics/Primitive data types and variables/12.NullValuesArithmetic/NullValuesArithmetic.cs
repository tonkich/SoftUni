using System;
class NullValuesArithmetic
{
        static void Main()
        {
            int? intNumber = null;
            double? doubleNumber = null;
            Console.WriteLine("Print numbers before assigns them with values");
            Console.WriteLine("Int number: {0} \nDouble number: {1}", intNumber, doubleNumber);
            Console.WriteLine();
            intNumber = 21;
            doubleNumber = 21.12343298;
            Console.WriteLine("Print numbers after assigns them with values");
            Console.WriteLine("Int number: {0} \nDouble number: {1}", intNumber, doubleNumber);
        }
}
