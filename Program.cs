using System;
using System.Collections.Specialized;
using System.IO;
class Program
{
    static void Main()
    {
        int count = 0;
        Console.Write("Введите номер строки: ");
        int number = int.Parse(Console.ReadLine());
        using (FileStream readOnlyStream = File.OpenRead(@"E:\laba2\1.txt"))
        {
            foreach (string animal in File.ReadAllLines(@"E:\laba2\1.txt"))
            {
                count++;
                if (count == number)
                {
                    Console.WriteLine($"Количество символов в строке под номером: {number}");
                    Console.WriteLine(animal.Length);
                    break;
                }




            }
        }
    }
}