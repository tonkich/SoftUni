using System;
class BankAccountData
{
        static void Main()
        {
            string firstName = "Anton";
            string middleName = "Tsvetkov";
            string lastName = "Kolev";
            decimal balance = 3423985264694396790576.5M;
            string bankName = "de Jewish Bank";
            string iban = "BG79UBBS921*****1039321";
            string bicCode = "44UBBS";

            ulong creditCard1 = 4234566768;
            ulong creditCard2 = 9345768946;
            ulong creditCard3 = 6575683453;

            //Print information about bank account
            Console.WriteLine("<< Account information >>\n\n");

            Console.WriteLine("First name:{0}\nMiddle name:{1}\nLast name:{2}\n", firstName, middleName, lastName);
            Console.WriteLine("Balance:{0}\nBank:{1}\nIBAN:{2}\nBIC:{2}\n", balance, bankName, iban, bicCode);
            Console.WriteLine("Credit card's number: {0}, {1}, {2}\n", creditCard1, creditCard2, creditCard3);
        }
}
