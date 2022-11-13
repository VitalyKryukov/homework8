// Задача 64: Задайте значение N. Напишите программу, которая выведет\
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Main();

void Main()
{
    Console.WriteLine("Start");
    Console.Write("Введите N: ");
    int N = int.Parse(Console.ReadLine());
    Console.Write($"N = {N} -> ");
    PrintValues(N);
    Console.WriteLine("End");
}

void PrintValues(int N)
{
    Console.Write($"{N}");
    // Если следующее значение будет меньше единицы, то прекращаем рекурсию.
    if(N - 1 < 1)
    {
        Console.WriteLine();
        return;
    }
    Console.Write($", ");
    PrintValues(N - 1);
}