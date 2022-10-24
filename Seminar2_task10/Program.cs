// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int secondDigit = Math.Abs(number);

if(secondDigit < 1000 && secondDigit > 99)
{
    // int a1 = number / 100;
    int a2 = secondDigit / 10 % 10;
    // int a3 = number % 10;
    Console.WriteLine($"Второй цифрой числа {number}, является {a2}.");
}
else
{
    Console.WriteLine("Ошибка! Введите трёхзначное число!");
}