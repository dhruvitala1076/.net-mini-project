//Write a program to convert given name in upper characters.
//INPUT : John F Kennedy
//OUTPUT: JOHN F KENNEDY
using System;

namespace ConsoleApplication1
{
    internal class uppercharcter
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";

            string upperName = name.ToUpper();
            Console.WriteLine("Output: " + upperName);

            Console.ReadLine();
        }
    }
}
