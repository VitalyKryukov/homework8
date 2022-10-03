// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.WriteLine("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine());
if (FirstNumber < SecondNumber)
{
    Console.Write("Первое число (" + FirstNumber + ") меньшее, второе число (" + SecondNumber + ") большее.");
}
else
{
    Console.Write("Первое число (" + FirstNumber + ") большее, второе число (" + SecondNumber + ") меньшее.");
}