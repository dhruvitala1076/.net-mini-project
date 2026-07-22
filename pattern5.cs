using System;
namespace PROJECT_01P
{
    class Pattern5
    {
        public static void pat6()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                    Console.Write(" ");

                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine();
            }

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 5; j > i; j--)
                    Console.Write(" ");

                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
