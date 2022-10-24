// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int thirdDigit = Math.Abs(number);

if(thirdDigit > 99)
{
    while(thirdDigit > 1000)
    {
        thirdDigit = thirdDigit / 10;
    }
    // Console.Write(thirdDigit);
    thirdDigit = thirdDigit % 10;
    Console.WriteLine($"Третьей цифрой числа {number} является {thirdDigit}");
}
else
{
    Console.WriteLine($"В числе {number} третьей цифры нет!");
}
