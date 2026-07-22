//Write a Program which accepts name and gender from the user. Here, gender may have only 1 character, M or F.
//Based on the gender prefix the name Mr. & Ms.
//NAME : Hillary Clinton
//GENDER : F
using System;
namespace PROJECT_01P
{
    class MorF
    {
        public static void M_F()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
                Console.WriteLine("Ms. " + name);
            else if (gender == 'F' || gender == 'f')
                Console.WriteLine("Mr. " + name);
            else
                Console.WriteLine("Invalid Gender");
        }
    }
}
