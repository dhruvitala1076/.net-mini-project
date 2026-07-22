using System;

namespace PROJECT_01P
{
    class Pattern2
    {
         public static void par3()
        {
            int num = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }

        }
    }
}
