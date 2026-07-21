//Write a Program to convert given name in toggle case.
//INPUT : JoHn F kEnNedy
//OUTPUT: jOhN f KeNneDY

using System;

class togglecase
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? "";

        string result = "";

        foreach (char ch in name)
        {
            if (char.IsUpper(ch))
                result += char.ToLower(ch);
            else if (char.IsLower(ch))
                result += char.ToUpper(ch);
            else
                result += ch;
        }

        Console.WriteLine("Output: " + result);
        Console.ReadLine();
    }
}
