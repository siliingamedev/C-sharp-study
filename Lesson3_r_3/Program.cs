using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_r_3
{
    class Program
    {
        int[] a;
        public Program(int n)
        {
            a = new int[n];
        }
        public int Get(int i)
        {
            return a[i];
        }
        public void Set(int i,int value)
        {
            a[i] = value;
        }
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }
        static void Main(string[] args)
        {
            Program array = new Program(10);
            for (int i = 0; i < 10; i++)
            {
                array.Set(i,i* 10);
                array[i] = i * 5;
            }
            int[] g = { 1,5,7,8,25};
            Console.Write(g[4]);
            Console.ReadKey();
            
        }
    }
}
