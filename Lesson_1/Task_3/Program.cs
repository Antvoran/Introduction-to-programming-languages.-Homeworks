// Написать программу, которая на входе принимает число, 
// а на выходе определяет, является ли оно чётным.

Console.WriteLine("Введите целое число:");
String Num = Console.ReadLine();
int Number = Convert.ToInt32(Num);
if (Number % 2 == 0){
    Console.WriteLine($"Число {Number} - чётное.");
}
else
Console.WriteLine($"Число {Number} - нечётное.");
