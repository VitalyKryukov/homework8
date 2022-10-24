// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
Console.Clear();

Console.WriteLine("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int Number3 = int.Parse(Console.ReadLine()!);
int max = Number1;
if (Number2 > max) max = Number2;
if (Number3 > max) max = Number3;
Console.Write("Максимальным числом из чисел (" + Number1 + ", " + Number2 + ", " + Number3 + ") является число " + max + ".");