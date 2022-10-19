// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Main();

// МЕТОДЫ:
//
void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int [] array = GetArray(new Random().Next(5,5), 100, 999);
    Console.WriteLine("Полученный массив: ");
    PrintArray(array);
    Console.WriteLine($"Сумма эллементов, стоящих на нечётных позициях равна {SumOddPosition(array)}");
    Console.WriteLine("End");
}

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        {
             Console.Write(", ");
        }
        // Console.WriteLine();
    }
    Console.Write("]\n");// <\n> - перенос строки
}

int SumOddPosition(int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}