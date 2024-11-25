using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submitted_Ex01
{
    internal class EX_03A
    {
        public static void Main3a()
        {
            //question01();
            //question02();
            //question03();
            //question04();
            //question05();
            Console.ReadKey();
        }
        public static void question01()
        {
            Console.Write("Nhap so thu nhat: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap toan tu (+,-,*,/): ");
            char operation = Console.ReadKey().KeyChar;
            if (operation == '+')
                Console.WriteLine($"Ket qua: {num1} + {num2} = {num1 + num2}");
            else if (operation == '-')
                Console.WriteLine($"Ket qua: {num1} - {num2} = {num1 - num2}");
            else if (operation == '*')
                Console.WriteLine($"Ket qua: {num1} * {num2} = {num1 * num2}");
            else if (operation == '/')
            {
                if (num2 == 0)
                    Console.WriteLine("Loi: Khong the chia cho o.");
                else Console.WriteLine($"Ket qua: {num1} / {num2} = {num1 / num2}");
            }
            else Console.WriteLine("Toan tu khong hop le.");
        }
        public static void question02()
        {
            Console.WriteLine("Gia tri cua ham x = y^2 + 2y + 1 voi y tu -5 den 5:");
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"y = {y}, x= {x}");
            }
        }
        public static void question03()
        {
            Console.Write("Nhap distance (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap hour: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap minute: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap second: ");
            int second = Convert.ToInt32(Console.ReadLine());
            double totalTIMEinHOUR = hour + (minute / 60.0) + (second / 3600.0);
            if (totalTIMEinHOUR == 0)
            {
                Console.WriteLine("Thoi gian khong hop le.");
                return;
            }
            double speedKMperHOUR = distance / totalTIMEinHOUR;
            double speedMILESperHOUR = speedKMperHOUR * 0.621371;
            Console.WriteLine($"Van toc: {speedKMperHOUR:F2} km/h");
            Console.WriteLine($"Van toc: {speedMILESperHOUR:F2} miles/h");

        }
        public static void question04()
        {
            Console.Write("Nhap ban kinh hinh cau: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double surfacearea = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Dien tich be mat hinh cau: {surfacearea:F2}");
            Console.WriteLine($"The tich hinh cau: {volume:F2}");
        }
        public static void question05()
        {
            Console.Write("Nhap mot ky tu: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ("aeiouAEIOU".IndexOf(inputChar) >= 0)
            {
                Console.WriteLine($"{inputChar} la mot nguyen am.");
            }
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"{inputChar} la mot chu so.");
            }
            else
            {
                Console.WriteLine($"{inputChar} la mot ky tu khac.");
            }
        }
    }
}
