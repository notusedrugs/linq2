using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Задача 1: Имена длины 3
        string[] names = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };
        var namesLength3 = names.Where(name => name.Length == 3);

        Console.WriteLine("Имена длины 3:");
        foreach (string name in namesLength3)
        {
            Console.WriteLine(name);
        }


        // Задача 2: Числа больше 10, делящиеся на 2
        int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
        var numbersGreaterThan10DivisibleBy2 = numbers.Where(num => num > 10 && num % 2 == 0);

        Console.WriteLine("\nЧисла больше 10, которые делятся на 2:");
        foreach (int number in numbersGreaterThan10DivisibleBy2)
        {
            Console.WriteLine(number);
        }
    }
}