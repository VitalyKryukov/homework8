// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

Main();

void Main(){
    Console.WriteLine("Start");
    int rowCount = 3, columtCount = 4;
    int [,] array = GetArray(rowCount, columtCount, 1, 10);
    PrintArray(array);
    Console.WriteLine();
    int[] rowsSum = RowsSum(array);
    PrintResult(rowsSum);
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

// Подсчёт суммы элементов по каждой строке.
// На выходе получаем одномерный массив, каждый элемент
// которого - сумма элементов соответствующей строки.
int [] RowsSum(int [,] array)
{
    int[] rowsSum = new int[array.GetLength(0)];

    for (int i = 0; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        rowsSum[i] = sum;
    }

    return rowsSum;
}

void PrintResult(int[] result)
{
    int minValueIndex = 0;
    
    // Определение индекса элемента с минимальным значением.
    for(int i = 0; i<result.GetLength(0); i++)
    {
        Console.WriteLine($"Сумма элементов {i + 1} строки равна {result[i]}");
        if(result[i] < result[minValueIndex])
        {
            minValueIndex = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minValueIndex + 1} строка");
}