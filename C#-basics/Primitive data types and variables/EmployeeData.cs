using System;
class EmployeeData
{
    static void Print(string firstName, string familyName, byte age, char gender, long IDnumber, ulong employeeNumber)
    {
        Console.WriteLine("Information about employee");
        Console.WriteLine("Name: {0} {1}", firstName, familyName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("ID number: " + IDnumber);
        Console.WriteLine("Employee number: " + employeeNumber);
    }
    static void Main(string[] args)
    {
        string firstName = "";
        string familyName = "";
        byte age = 0;
        char gender = ' ';
        long IDnumber = 0;
        ulong employeeNumber = 0;
        Console.Write("First name: ");
        firstName = Console.ReadLine();
        Console.Write("Family name: ");
        familyName = Console.ReadLine();
        Console.Write("Age: ");
        age = byte.Parse(Console.ReadLine());
        Console.Write("Gender (m or f): ");
        gender = char.Parse(Console.ReadLine());
        if (gender != 'm' && gender != 'f')
        {
            while (gender != 'm' && gender != 'f')
            {
                Console.Write("ERROR. Gender must be 'm' or 'f'. Enter gender again: ");
                gender = char.Parse(Console.ReadLine());
            }
        }
        Console.Write("ID number: ");
        IDnumber = long.Parse(Console.ReadLine());
        Console.Write("Unique employee number (27560000 - 27569999): ");
        employeeNumber = ulong.Parse(Console.ReadLine());
        if (employeeNumber < 27560000 || employeeNumber > 27569999)
        {
            while (employeeNumber < 27560000 || employeeNumber > 27569999)
            {
                Console.Write("ERROR. Employee number must be in range (27560000 - 27569999). Enter again: ");
                employeeNumber = ulong.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        Print(firstName, familyName, age, gender, IDnumber, employeeNumber);
    }
}