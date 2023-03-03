// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Чётные числа в промежутке от " + m + " до " + n + ":");

        PrintEvenNumbers(m, n);
    }

    static void PrintEvenNumbers(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        if (start % 2 == 0)
        {
            Console.WriteLine(start);
        }

        PrintEvenNumbers(start + 1, end);
    }
}
