// Write a Program which accepts mobile no as a string from the user and converts the last 5 digits into X.
//INPUT : 1234567890
//OUTPUT: 12345XXXXX
using System;
class convert_5digit_X
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Mobile Number: ");
        string mobile = Console.ReadLine();
        string result = mobile.Substring(0, 5) + "XXXXX";
        Console.WriteLine("Output: " + result);
        Console.ReadLine();
    }
}

