using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Xml.Serialization;

namespace Players_Handbook.NewFolder
{
    internal class replicator
    {
        public static void Run()
        {
            int[] array1 = new int[5];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Enter a number for array1:");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array2 = new int[5];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }

            Console.WriteLine("Array 1:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine("Array 2:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }

    }
}

