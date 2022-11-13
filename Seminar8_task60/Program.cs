﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Main();

void Main(){
    Console.WriteLine("Start");
    int rowCount = 2, columtCount = 2, depth = 2;
    int [,,] array = GetArray(rowCount, columtCount, depth, 10, 100);
    PrintArray(array);
    Console.WriteLine("End");
}

int [,,] GetArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int [,,] result = new int[rows, columns, depth];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < depth; k++)
            {
                int value = new Random().Next(minValue, maxValue);
                // Получение случайных чисел до тех пор, пока не получим число,
                // которого ещё нет в массиве result.
                while(Contains(result, value))
                {
                    value = new Random().Next(minValue, maxValue);
                }
                result [i,j,k] = value;
            }
        }
    }
    return result;
}

void PrintArray(int [,,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for(int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

bool Contains(int [,,] array, int value)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i,j,k] == value){
                    return true;
                }
            }
        }
    }
    return false;
}