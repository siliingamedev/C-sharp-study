using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_pr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rang = 5;
            matrixA A = new matrixA();
            int[,] a;
            int[,] b;
            a = A.setMatrix(rang);
            Console.WriteLine();
            b = A.setMatrix(rang);
            Console.WriteLine();
            A.summMatrix(a, b, rang);
            Console.WriteLine();
            A.proizvMAtrix(a, b, rang);
            Console.ReadKey();
        }
    }
    class matrixA
    {
        public int[,] setMatrix(int rang)
        {
            int[,] a = new int[rang, rang];
            Random rnd = new Random();
            for (int i = 0; i < rang; i++)
            {
                for (int j = 0; j < rang; j++)
                {
                    a[i, j] = rnd.Next(0,10);
                    Console.Write("{0}\t",a[i,j]);
                }
                Console.WriteLine();
            }
            return a;
        }
        public int getElem(int[,]a,int i,int j)
        {
            return a[i, j];
        }
        public int[,] summMatrix(int[,] a, int[,] b, int rang)
        {
            int[,] c = new int[rang, rang];
            for (int i = 0; i < rang; i++)
            {
                for (int j = 0; j < rang; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write("{0}\t", c[i, j]);
                }
                Console.WriteLine();
            }
            return c;
        }
        public void proizvMAtrix(int[,] a, int[,] b, int rang)
        {
            int[,] c = new int[rang, rang];
            for (int i = 0; i < rang; i++)
            {
                for (int j = 0; j < rang; j++)
                {
                    c[i, j] = a[i, j] * b[i, j];
                    Console.Write("{0}\t", c[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
