using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_r_5
{
    class Program
    {
        static int Poisk(int[] i)
        {
            int s = 0;
            for (int j = 0; j<i.Length ; j++)
            {
                if (i[j] == 51) s = j;
                else s = 1;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int[] array = {34,56,2,10,77,50,93,30};
            Console.Write(Poisk(array));
            Console.ReadKey();

        }
    }
}
