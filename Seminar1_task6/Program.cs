﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
if (Math.Abs(Number) % 2 == 1)// Метод Math.Abs(-2) = 2 - решает проблему с отрицательными числами.
{
    Console.Write("Число (" + Number + ") не чётное.");
}
else
{
    Console.Write("Число (" + Number + ") чётное.");
}