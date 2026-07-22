using System;
namespace PROJECT_01P
{
    class pattern1
    {
        public static void par2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
