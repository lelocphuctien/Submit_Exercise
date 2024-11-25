using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submitted_Ex01
{
    internal class EX_07A
    {
        public static void NhapMang(int[,] a, int d, int c)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void nhaprand(int[,] a, int d, int c)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i}, {j}] = ");
                    a[i, j] = rand.Next(0, 100);
                }
            }
        }
        public static void Xuatmang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
        public static void Tim(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai dong {i}, cot {j}\n");
                        return;
                    }
                }
            }
        }
        public static void Main7(string[] args)
        {
            int[,] a;
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int cols = int.Parse(Console.ReadLine());
            //tao mang 2 chieu
            a = new int[rows, cols];
            //Nhap mang bang
            NhapMang(a, rows, cols);
            Xuatmang(a);

            Console.WriteLine();
            Console.Write("Nhap so can tim: ");
            int val = int.Parse(Console.ReadLine());
            Tim(a, val);
        }
    }

}

