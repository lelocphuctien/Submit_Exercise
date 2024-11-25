using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class EX_06
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter the number: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter value for item {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nArray before incrementing: ");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] += 2;
        }
        Console.WriteLine("\nArray before incrementing by 2: ");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

