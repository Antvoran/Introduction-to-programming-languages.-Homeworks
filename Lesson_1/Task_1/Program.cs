// Написать программу, которая на входе принимает два числа, а на выходе определяет, 
// какое из них больше, а какое меньше.

Console.WriteLine("Введите первое целое число:");
String firstNum = Console.ReadLine();
int firstNumber = Convert.ToInt32(firstNum);
Console.WriteLine("Введите второе целое число:");
String secondNum = Console.ReadLine();
int secondNumber = Convert.ToInt32(secondNum);
if (firstNumber > secondNumber) {
    Console.WriteLine($"Первое число {firstNumber} больше, чем второе число {secondNumber}.");
}
else
Console.WriteLine($"Второе число {secondNumber} больше, чем первое число {firstNumber}.");
