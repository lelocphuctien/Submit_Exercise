using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submitted_Ex01
{
    internal class EX_03C
    {
        public static void Main3c()
        {
            //question01();
            //question02();
            //question03();
            //question05_a();
            //question05_b(); 
            //question05_c();
            //question06(); 
            //question07(); 
            //question08();
            Console.ReadKey();
        }
        public static void question01()
        {
            Console.Write("Nhap canh thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh thu ba: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Day la tam giac deu.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Day la tam giac can.");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong.");
                }
            }
            else
            {
                Console.WriteLine("Ba canh nay khong tao thanh mot tam giac.");
            }
        }
        public static void question02()
        {
            double sum = 0;
            int count = 10;
            Console.WriteLine("Nhap 10 so: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Nhap so thu {i}: ");
                double number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            }
            double average = sum / count;
            Console.WriteLine($"\nTong cua 10 so: {sum}");
            Console.WriteLine($"Gia tri trung binh: {average}");
        }
        public static void question03()
        {
            Console.WriteLine("Nhap mot so nguyen: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nBang cuu chuong cua {number}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        public static void question05_a()
        {
            Console.WriteLine("Mau 1:");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public static void question05_b()
        {
            Console.WriteLine("Mau 2:");
            int number = 1; // Biến bắt đầu đếm

            // Vòng lặp để kiểm soát hàng
            for (int i = 1; i <= 4; i++) // 4 hàng
            {
                // Vòng lặp để in số trong mỗi hàng
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " "); // In số và dấu cách
                    number++; // Tăng số
                }
                Console.WriteLine(); // Xuống dòng sau khi in xong mỗi hàng
            }
        }
        public static void question05_c()
        {
            {
                Console.WriteLine("Mau 3:");

                int number = 1; // Bắt đầu từ số 1

                // Vòng lặp điều khiển số hàng
                for (int i = 1; i <= 4; i++) // 4 hàng
                {
                    // In khoảng cách để canh giữa
                    for (int space = 4; space > i; space--)
                    {
                        Console.Write(" "); // In khoảng cách
                    }

                    // In các số trong hàng
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(number + " "); // In số và dấu cách
                        number++; // Tăng giá trị số
                    }

                    Console.WriteLine(); // Xuống dòng sau khi in xong hàng
                }
            }
        }
        public static void question06()
        {
            Console.Write("Nhap so luong so hang: ");
            int n = Convert.ToInt32((string)Console.ReadLine());
            double sum = 0.0;
            Console.Write("Day so dieu hoa: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}"); // In số hạng
                if (i < n)
                {
                    Console.Write(" + "); // Thêm dấu cộng nếu chưa phải số cuối
                }
                sum += 1.0 / i; // Cộng số hạng vào tổng
            }
            //Hiển thị tổng
            Console.WriteLine($"\nTong cua day: {sum:F2}");
        }
        public static void question07()
        {
            Console.Write("Nhap so bat dau cua khoang (a): ");
            int start = Convert.ToInt32((string)Console.ReadLine());
            Console.Write("Nhap so bat dau cua khoang (b): ");
            int end = Convert.ToInt32((string)Console.ReadLine());
            Console.WriteLine($"\nCac so hoan hao trong khoang tu {start} toi {end} la: ");
            for (int number = start; number <= end; number++)
            {
                if (IsPerfectNumber(number))
                {
                    Console.WriteLine(number);
                }
            }
            static bool IsPerfectNumber(int num)
            {
                if (num <= 1) return false;

                int sum = 0;

                // Tìm tất cả các ước của num (trừ chính nó)
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }

                // Kiểm tra nếu tổng các ước bằng chính số
                return sum == num;
            }
        }
        public static void question08()
        {
            Console.Write("Nhap mot so nguyen: ");
            int number = Convert.ToInt32((string)Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{number} khong phai la so nguyen to.");
            }
            static bool IsPrime(int num)
            {
                if (num <= 1)
                {
                    return false; // Các số <= 1 không phải số nguyên tố
                }
                // Kiểm tra các ước từ 2 đến căn bậc hai của num
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false; // Nếu chia hết, không phải số nguyên tố
                    }
                }

                return true; // Là số nguyên tố
            }
        }
    }
}

