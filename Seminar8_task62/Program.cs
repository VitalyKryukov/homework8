// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Main();

void Main(){
    Console.WriteLine("Start");
    int rowCount = 4, columtCount = 4;
    int [,] array = GetSpiralArray(rowCount, columtCount);
    PrintArray(array);
    Console.WriteLine("End");
}

int [,] GetSpiralArray(int rows, int columns)
{
    int [,] result = new int[rows, columns];
    int lastValue = 1;
    for (int i = 0; i < rows/2; i++)
    {
    lastValue = FillCircle(ref result, i, lastValue);
    }
    //FillCircle(ref result, 1, lastValue);
    return result;
}

// Заполнить заданный контур [circleNumber] массива [array] начиная со значения [startValue].
int FillCircle(ref int [,] array, int circleNumber, int startValue)
{
    int currentValue = startValue;

    // Заполнение верхней границы контура (слева направо).
    for(int i = circleNumber; i < array.GetLength(1) - circleNumber - 1; i++)
    {
        array[circleNumber,i] = currentValue;
        currentValue++;
    }
    
    // Заполнение правой границы контура (сверху вниз).
    for(int i = circleNumber; i < array.GetLength(0) - circleNumber - 1; i++)
    {
        array[i,array.GetLength(1) - circleNumber - 1] = currentValue;
        currentValue++;
    }
    
    // Заполнение нижней границы контура (справа налево).
    for(int i = array.GetLength(1) - circleNumber - 1; i >= circleNumber + 1; i--)
    {
        array[array.GetLength(0) - circleNumber - 1,i] = currentValue;
        currentValue++;
    }

    // Заполнение левой границы контура (снизу вверх).
    for(int i = array.GetLength(0) - circleNumber - 1; i >= circleNumber + 1; i--)
    {
        array[i,circleNumber] = currentValue;
        currentValue++;
    }

    // Возвращаем значение, на котором завершили заполнение.
    return currentValue;
}

void PrintArray(int [,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(inArray[i,j].ToString().Length < 2){
                Console.Write("0");
            }
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
