// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
int a1 = Math.Abs(number);//вводим для нахождения первых 3-х цифр

if(Math.Abs(number) > 9999 && Math.Abs(number) < 100000)
    {
    while(a1 > 1000)
        {
            a1 = a1 / 10;
        }
    a1 = a1/100*10000 + a1/10%10*1000 + a1%10*100 + a1/10%10*10 + a1/100;
    if(a1 == Math.Abs(number))
    {
        Console.WriteLine($"Число {number} является полиндромом!");
    }
    else
    {
        Console.WriteLine($"Число {number} не является полиндромом!");
    }
    }
else
{
    Console.WriteLine("Ошибка! Введите пятизначное число!");
}
