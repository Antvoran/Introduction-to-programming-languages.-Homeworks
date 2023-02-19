// Написать программу, которая на входе принимает три числа, 
// а на выходе выдаёт максимальное число.

Console.WriteLine("Введите первое целое число:");
String firstNum = Console.ReadLine();
int firstNumber = Convert.ToInt32(firstNum);
Console.WriteLine("Введите второе целое число:");
String secondNum = Console.ReadLine();
int secondNumber = Convert.ToInt32(secondNum);
Console.WriteLine("Введите третье целое число:");
String thirdNum = Console.ReadLine();
int thirdNumber = Convert.ToInt32(thirdNum);
if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine($"Первое число {firstNumber} - максимальное из трёх.");
    }
    else
        Console.WriteLine($"Третье число {thirdNumber} - максимальное из трёх.");
}
else 
if (secondNumber > thirdNumber){
    Console.WriteLine($"Второе число {secondNumber} - максимальное из трёх.");
}
else
    Console.WriteLine($"Третье число {thirdNumber} - максимальное из трёх.");
