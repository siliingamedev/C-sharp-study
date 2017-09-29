using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_pr_2
{
    class MyArray
    {
        int[] a;
        public MyArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(min,max);
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < min) min = a[i];
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max) max = a[i];
                }
                return max;
            }
        }
        public int AverageValue
        {
            get
            {
                int av = 0;
                int sum = 0;
                int n = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum = sum + a[i];
                    n++;
                }
                av = sum / n;
                return av;
            }
        }
        public int CountPositiv
        {
            get
            {
                int cp = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0) cp++;
                }
                return cp;
            }
        }
        public void NToString()
        {
            foreach (int v in a)
            {
                Console.Write("{0}\t", v);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(5);
            MyArray array1 = new MyArray(10, -5, 5);
            Console.WriteLine(array.Max);
            Console.WriteLine(array.Min);
            Console.WriteLine();
            array1.NToString();
            Console.WriteLine();
            Console.WriteLine(array1.CountPositiv);
            Console.WriteLine(array1.AverageValue);
            array1.ToString();
            Console.ReadKey();
        }
    }
}
