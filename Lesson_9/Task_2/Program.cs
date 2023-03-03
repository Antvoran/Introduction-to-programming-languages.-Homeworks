// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// чисел в промежутке от M до N.
class Program {
    static void Main(string[] args) {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = m; i <= n; i++) {
            sum += i;
        }

        Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}");
    }
}