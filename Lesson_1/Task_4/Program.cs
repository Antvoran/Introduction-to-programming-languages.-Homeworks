// Написать программу, которая на входе принимает число N, 
// а на выходе выдаёт все чётные числа от 1 до N.

Console.WriteLine("Введите целое положительное число:");
String Num = Console.ReadLine();
int Number = Convert.ToInt32(Num);
int i = 2;
Console.WriteLine($"Чётные числа от 1 до {Number}:");
while (i < Number + 1){
    Console.Write($"{i}, ");
    i = i + 2;
    }
