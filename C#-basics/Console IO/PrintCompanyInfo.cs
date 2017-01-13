using System;
    class Info
    {
        static void Main(string[] args)
        {
            string companyName, address, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerPhoneNumber;
            byte managerAge;
            Console.Write("Enter the name of the company: ");
            companyName = Console.ReadLine();
            Console.Write("Enter the address of the company: ");
            address = Console.ReadLine();
            Console.Write("Enter the phone number of the company: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Enter the fax number of the company: ");
            faxNumber = Console.ReadLine();
            Console.Write("Enter the web site of the company: ");
            webSite = Console.ReadLine();
            Console.Write("Enter the first name of the manager: ");
            managerFirstName = Console.ReadLine();
            Console.Write("Enter the last name of the manager: ");
            managerLastName = Console.ReadLine();
            Console.Write("Enter the age of the manager: ");
            bool isAgeByte = byte.TryParse(Console.ReadLine(), out managerAge);
            Console.Write("Enter the phone number of the manager:");
            managerPhoneNumber = Console.ReadLine(); 
            if (isAgeByte)
            {
                Console.WriteLine();
                Console.WriteLine("Company name:".PadRight(23, ' ') + "{0,30}".PadRight(30, ' '), companyName);
                Console.WriteLine("Address:".PadRight(23, ' ') + "{0,30}".PadRight(30, ' '), address);
                Console.WriteLine("Phone number:".PadRight(23, ' ') + "{0,30}".PadRight(30, ' '), phoneNumber);
                Console.WriteLine("Fax number:".PadRight(23, ' ') + "{0,30}".PadRight(30, ' '), faxNumber);
                Console.WriteLine("Web site:".PadRight(23, ' ') + "{0,30}".PadRight(30, ' '), webSite);
                Console.WriteLine("Manager:".PadRight(23, ' ') + "{0,30}".PadRight(30, ' '), managerFirstName + " " + managerLastName);
                Console.WriteLine("Manager's age:".PadRight(23, ' ') + "{0,30}".PadRight(30, ' '), managerAge);
                Console.WriteLine("Manager's phone number:".PadRight(23, ' ') + "{0,30}".PadRight(30, ' '), managerPhoneNumber);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Manager's age is not a byte number!");
            }
        }
    }
