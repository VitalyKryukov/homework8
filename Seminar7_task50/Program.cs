// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Main();

//Методы

void Main()
{
Console.WriteLine("Start");
int m = 3, n = 4;
int [,] array = GetArray(m, n, 1, 10);
PrintArray(array);
Console.WriteLine("Введите позицию строки: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию столбца: ");
int col = int.Parse(Console.ReadLine());
Console.WriteLine($"[{row}, {col}] -> {PositionArray(array, row, col)}");
Console.WriteLine("End");
}

int [,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int [,] result = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result [i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int [,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}



string PositionArray(int [,] posArray, int row, int col)
{
    try
    {
        return posArray [row, col].ToString();
    }
    catch
    {
        return "такого числа в массиве нет!";
    }
}

