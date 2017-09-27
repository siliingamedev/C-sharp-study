using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_r_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array0;
            array0 = new int[5];
            int[] array1 = new int[6];
            int[] array2 = new int[] { 1,2,3,4,5,6,7,8};
            int[] array3 = { 0,1,2,3,4,5,6,7,8,9};
            array0[2] = 10;
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            foreach (int i in array3)
            {
                Console.WriteLine(array3[i]);
            }
            int j;
            for (j = 0; j < array2.Length; j++)
            {
                array2[j] = j * j;
                Console.WriteLine(array2[j]);
            }
            Console.ReadKey();
        }   
    }
}
