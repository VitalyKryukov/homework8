// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();

Console.WriteLine("Введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine()!);

if(number > 0 && number < 8)
{
    if (number == 1)
    {
        Console.WriteLine($"{number} -> нет");
    }

    if (number == 2)
    {
        Console.WriteLine($"{number} -> нет");
    }

    if (number == 3)
    {
        Console.WriteLine($"{number} -> нет");
    }

    if (number == 4)
    {
        Console.WriteLine($"{number} -> нет");
    }

    if (number == 5)
    {
        Console.WriteLine($"{number} -> нет");
    }

    if (number == 6)
    {
        Console.WriteLine($"{number} -> да");
    }

    if (number == 7)
    {
        Console.WriteLine($"{number} -> да");
    }
}
else
{
    Console.WriteLine($"{number} не является днем недели!");
}