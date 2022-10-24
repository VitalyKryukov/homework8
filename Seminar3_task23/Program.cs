// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
double CubeNumber = 0;
if(number > 0) //для положительных чисел
{
    for(int i = 0; i <= number; i++)
    {
        CubeNumber = Math.Pow(i,3);
        Console.WriteLine($"Куб числа {i} = {CubeNumber}");
    }
}
else //для отрицательных чисел
{
    for(int i = 0; i >= number; i--)
    {
        CubeNumber = Math.Pow(i,3);
        Console.WriteLine($"Куб числа {i} = {CubeNumber}");
    }
}
