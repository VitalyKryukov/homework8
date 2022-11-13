// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Main();

void Main(){
    Console.WriteLine("Start");
    int rowCount = 3, columtCount = 4;
    int [,] array = GetArray(rowCount, columtCount, 1, 10);
    PrintArray(array);
    Console.WriteLine();
    int [,] sortedArray = SortArray(array);
    PrintArray(sortedArray);
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

// Сортировка строк массива array по убыванию.
int [,] SortArray(int [,] array)
{
    int[,] sortedArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i<array.GetLength(0); i++)
    {
        // Создаём одномерный массив [rowArray] из строки двумерного массива [array].
        int[] rowArray = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowArray[j] = array[i,j];
        }

        // Сортируем этот массив по возрастанию.
        Array.Sort(rowArray);
        // Переворачиваем массив.
        Array.Reverse(rowArray);
        
        // Переписываем получившуюся отсортированную строку в результирующий массив.
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortedArray[i,j] = rowArray[j];
        }
    }

    return sortedArray;
}