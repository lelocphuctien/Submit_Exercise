using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submitted_Ex01
{
    internal class EX_04
    {
        public static void Main4()
        {
            int a = 2;
            int b = 5;
            int c = 3;
            int m = max(a, b, c);
            Console.WriteLine(m);

            Console.WriteLine("Nhap vao n de tinh giai thua: ");
            int n1 = int.Parse(Console.ReadLine());
            int m1 = giaithua(n1);
            Console.WriteLine(m1);

            Console.WriteLine("Nhap vao n de xet so nguyen to: ");
            int n8 = int.Parse(Console.ReadLine());
            int m2 = nguyento(n8);
            if (m2 == 1)
            { Console.WriteLine($"{n8} la so nguyen to"); }
            else Console.WriteLine($"{n8} khong phai la so nguyen to");

            Console.WriteLine("Nhap vao n: ");
            int n3 = int.Parse(Console.ReadLine());
            c4_1(n3);

            Console.WriteLine("Nhap vao n: ");
            int n4 = int.Parse(Console.ReadLine());
            c4_2(n4);


            Console.WriteLine("Nhap vao n: ");
            int n5 = int.Parse(Console.ReadLine());
            int m5 = hoanhao(n5);
            if (m5 == 1)
            {
                Console.WriteLine($"{n5} la so hoan hao");
            }
            else Console.WriteLine($"{n5} khong phai la so hoan hao");


            hoanhaoduoi1000();

            Console.WriteLine("Nhap vao gi do: ");
            string str = Console.ReadLine();
            pangram(str);

            Console.ReadKey();
        }

        public static int max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        public static int giaithua(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            return s;
        }

        public static int nguyento(int n)
        {
            if (n < 2) return 0;
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    dem++;
            }
            if (dem == 2) return 1; else return 0;
        }

        public static void c4_1(int n)
        {
            Console.WriteLine($"Cac so nguyen to truoc {n} la: ");

            for (int i = 2; i < n; i++)
                if (nguyento(i) == 1) Console.Write(i + " ");
        }

        public static void c4_2(int n)
        {
            int x = 2;
            int dem = 0;
            Console.WriteLine($"{n} so nguyen to dau tien la: ");
            while (dem < n)
            {
                if (nguyento(x) == 1)
                {
                    Console.Write(x + " ");
                    dem++;
                }
                x++;
            }
            Console.WriteLine();
        }

        public static int hoanhao(int n)
        {
            int dem = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    dem += i;
            }
            if (n == dem) return 1; else return 0;
        }

        public static void hoanhaoduoi1000()
        {

            Console.WriteLine($" Tat ca cac so hoan hao nho hon 1000 la: ");
            for (int i = 1; i < 1000; i++)
            {
                if (hoanhao(i) == 1)
                    Console.WriteLine(i + " ");
            }
            Console.WriteLine();

        }

        public static void pangram(string str)
        {
            int compteur = 26;
            for (int i = 0; i <= str.Length; i++)
            {
                if (('A' <= str[i] && str[i] <= 'Z') || ('a' <= str[i] && str[i] <= 'z'))
                {
                    for (int j = str[i + 1]; j <= str.Length; j++)
                    {
                        if ((compteur != 0) && (str[i] != str[j]))
                        {
                            compteur = compteur - 1;
                        }
                    }
                }
                if (compteur == 26) Console.WriteLine("pangram");
                else Console.WriteLine("not pangram");
            }
        }

    }
}