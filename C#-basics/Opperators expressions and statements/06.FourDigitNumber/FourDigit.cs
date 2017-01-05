using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class FourDigit
{
        static void Main(string[] args)
        {

            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            int fourthDigit = number % 10;
            int restNumberTwo = number / 10;
            int thirdDigit = restNumberTwo % 10;
            int restNumberThree = number / 100;
            int secondDigit = restNumberThree % 10;
            int restNumberFour = number / 1000;
            int firstDigit = restNumberFour % 10;
            Console.WriteLine("Number " + number);
            Console.WriteLine("Sum of digits " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("Reversed {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("Last digit in front {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
}
