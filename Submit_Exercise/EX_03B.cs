using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submitted_Ex01
{
    internal class EX_03B
    {
        public static void Main3b()
        {
            //question01();
            //question02();
            //question03();
            Console.ReadKey();
        }
        public static void question01()
        {
            Console.Write("Nhap mot so nguyen: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} la so chan.");
            }
            else
            {
                Console.WriteLine($"{number} la so le.");
            }
        }
        public static void question02()
        {
            Console.Write("Nhap so thu nhat: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            double largest;
            if (number1 >= number2 && number1 >= number3)
            {
                largest = number1;
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                largest = number2;
            }
            else
            {
                largest = number3;
            }
            Console.WriteLine($"So lon nhat trong ba so la: {largest}");
        }
        public static void question03()
        {
            Console.Write("Nhap gia tri toa do X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap gia tri toa do Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Diem toa do {x}, {y} nam trong phan tu thu nhat.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Diem toa do {x}, {y} nam trong phan tu thu hai.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Diem toa do {x}, {y} nam trong phan tu thu ba.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Diem toa do {x}, {y} nam trong phan tu thu tu.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"Diem toa do{x},{y} nam tai goc toa do.");
            }
            else if (x == 0)
            {
                Console.WriteLine($"Diem toa do ({x},{y} nam tren truc Y.");
            }
            else if (y == 0)
            {
                Console.WriteLine($"Diem toa do ({x},{y} nam tren truc X.");
            }
        }
    }
}
