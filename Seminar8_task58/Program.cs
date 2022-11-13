// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Гуглить, как происходит умножение 2-х матриц. с. преподаватель.

// Неплохие иллюстрации умножения матриц https://www.mathsisfun.com/algebra/matrix-multiplying.html
// Размер результирующей матрицы https://en.wikipedia.org/wiki/Matrix_multiplication
// 4-й пример по ссылке https://function-x.ru/operations_with_matrices.html

Main();

void Main(){
    Console.WriteLine("Start");
    int rowCount = 3, columtCount = 4;
    // Создаём первую матрицу.
    int [,] arrayFirst = GetArray(rowCount, columtCount, 1, 10);
    // Создаём вторую матрицу, где количество строк и столбцов будет обратным (обязательное условие для произведения матриц)
    int [,] arraySecond = GetArray(columtCount, rowCount, 1, 10);

    PrintArray(arrayFirst);
    Console.WriteLine();
    PrintArray(arraySecond);
    Console.WriteLine();

    int[,] matrixMultiplication = MatrixMultiplication(arrayFirst, arraySecond);
    Console.WriteLine("Результат произведения матриц:");
    PrintArray(matrixMultiplication);
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

// Произведение матриц.
int [,] MatrixMultiplication(int [,] first, int [,] second)
{
    int[,] result = new int[first.GetLength(0), second.GetLength(1)];

    for (int i = 0; i<first.GetLength(0); i++)  // Строки первой матрицы
    {
        int sum = 0;
        for (int j = 0; j < second.GetLength(1); j++) // Столбцы второй матрицы
        {
            for (int k = 0; k < first.GetLength(1); k++) // Столбцы первой матрицы
            {
                sum += first[i,k] * second[k,j];
            }
            result[i,j] = sum;
        }
        
    }
    return result;
}