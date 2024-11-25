using System.Text;
using System;

public class Exercises_01
{
    public static void Main1()
    {  //question_01();
       //question_02();
       //question_03();
       //question_04();
       //question_05();
       //question_06();
       //question_07();
       //question_08();
       //question_09();
       //question_10();
        Console.ReadKey();
    }
    public static void question_01()
    {
        //Add 2 numbers
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine($"{a}+{b}={c}");
    }
    public static void question_02()
    {
        //Swap values of 2 variables
        Console.Write("Nhap gia tri x: ");
        string x = Console.ReadLine();
        Console.Write("Nhap gia tri y: ");
        string y = Console.ReadLine();
        string z;
        z = x; x = y; y = z;
        Console.WriteLine($"Gia tri x sau khi doi cho la: {x}");
        Console.WriteLine($"Gia tri y sau khi doi cho la: {y}");
    }
    public static void question_03()
    {
        //Multiply 2 floating numbers
        Console.Write("Nhap so a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        float b = float.Parse(Console.ReadLine());
        float c = a * b;
        Console.WriteLine($"{a}*{b}={c}");
    }
    public static void question_04()
    {
        //Convert feet to meter
        Console.Write("Nhap Feet: ");
        double feet = double.Parse(Console.ReadLine());
        double meter = feet / 3.281;
        Console.WriteLine($"Chuyen Feet sang Meter: {meter}");
    }
    public static void question_05()
    {
        //Convert Celcius to Fahrenheit and vice versa
        Console.Write("Nhap do C: ");
        double c = double.Parse(Console.ReadLine());
        double f = c * 9 / 5 + 32;
        Console.WriteLine($"{c}°C se bang {f}°F");
        Console.Write("Nhap do F: ");
        double F = double.Parse(Console.ReadLine());
        double C = (F - 32) * 5 / 9;
        Console.WriteLine($"{F}°F se bang {C}°C");
    }
    public static void question_06()
    {
        //Find the size of data types
        Console.WriteLine("Kich thuoc cua kieu du lieu int la: " + sizeof(int));
        Console.WriteLine("Kich thuoc cua kieu du lieu char la: " + sizeof(char));
        Console.WriteLine("Kich thuoc cua kieu du lieu double la: " + sizeof(double));
        Console.WriteLine("Kich thuoc cua kieu du lieu float la: " + sizeof(float));
    }
    public static void question_07()
    {
        //Character to ASCII
        Console.Write("Nhap gi do di: ");
        string x = Console.ReadLine();
        foreach (char c in x)
        { Console.Write((int)c + " "); }
        //char x = 'a';
        //int num = x;
        //Console.WriteLine($"{x} in ASCII = {num}");
    }
    public static void question_08()
    {
        //Calculate area of circle
        Console.Write("Nhap ban kinh hinh tron: ");
        float x = float.Parse(Console.ReadLine());
        double S = x * x * 3.14;
        Console.Write($"Dien tich hinh tron la: {S}");
    }
    public static void question_09()
    {
        //Calculate area of square
        Console.Write("Nhap ban kinh hinh vuong: ");
        float x = float.Parse(Console.ReadLine());
        double S = x * x;
        Console.Write($"Dien tich hinh vuong la: {S}");
    }
    public static void question_10()
    {
        //Convert days to years, weeks and days
        Console.Write("Nhap so ngay: ");
        int d = int.Parse(Console.ReadLine());
        int y = d / 365;
        int w = (d - y * 365) / 7;
        int d2 = d - y * 365 - w * 7;
        Console.Write($"{d} days = {y} years, {w} weeks, {d2} days");
    }
}
