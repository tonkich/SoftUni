using System;
class VariableInHexadecimalFormat
{
        static void Main()
        {
            int myInt = 254;
            string myHex = myInt.ToString("X");  
            int myNewInt = Convert.ToInt32(myHex, 16);
            Console.WriteLine("{0},{1}", myHex, myNewInt);
        }
}
