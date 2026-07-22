using System;
namespace PROJECT_01P
{
    class Pattern4
    {
        public static void par5()
        {
            int num = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                    Console.Write(" ");

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }

        }
    }
}
