// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве = {EvenNumbers(array)}");
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
    Console.Write("]");
}

int EvenNumbers(int [] array)
{
    int countEvenNum = 0;
    foreach(int el in array)
    {
    if(el%2 == 0)
        countEvenNum ++;
    }
    return countEvenNum;
}

