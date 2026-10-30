using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    internal class countdown
    {
        public static void Run()
        {
            int countdown(int num)
            {
                if (num == 1) return 1;
                else
                    return countdown(num - 1);
            }

            Console.WriteLine(countdown(10));

        }
    }
}