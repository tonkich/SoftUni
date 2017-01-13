using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Card
{
        static void Main()
        {

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", };
            Console.Write("Enter card: ");
            string stringToCheck = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                bool check = (stringToCheck == cards[i]);
                if (check)
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                Console.WriteLine("Valid card sign? Yes.");
            }
            else
            {
                Console.WriteLine("Valid card sign? No.");
            }

        }
}