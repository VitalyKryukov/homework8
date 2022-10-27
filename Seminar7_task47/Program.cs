// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Main();

//Методы

void Main()
{
Console.WriteLine("Start");
Console.Write("Введите количество строк (m):");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n):");
int n = int.Parse(Console.ReadLine());
double [,] array = GetArray(m, n, 1, 10);
PrintArray(array);
Console.WriteLine("End");
}

double [,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    double [,] result = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result [i,j] = new Random().Next(minValue,maxValue) + Math.Round(new Random().NextDouble(),1);
        }
    }
    return result;
}

void PrintArray(double [,] inArray)
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