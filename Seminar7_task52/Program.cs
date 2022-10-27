// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Main();

//Методы

void Main()
{
Console.WriteLine("Start");
int m = 3, n = 4;
int [,] array = GetArray(m, n, 1, 10);
PrintArray(array);
Average(array);
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

void Average (int [,] avArray)
{ 
    for (int i = 0; i<avArray.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < avArray.GetLength(0); j++)
        {
            sum += avArray[j,i];
        }
        double AverageResult = Math.Round(sum / avArray.GetLength(0),1);
        Console.Write($"{AverageResult}; ");
    }
}

