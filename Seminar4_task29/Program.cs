// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Main();

// МЕТОДЫ:
//
void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    PrintArray(8);
    Console.WriteLine();
    Console.WriteLine("End");
}

void PrintArray(int size)//метод ввода и печати массива
{
    int [] res = new int [size];
    Console.Write("[");
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next();
        Console.Write($"{res[i]}");
        if (i != size - 1)
        {
             Console.Write(", ");
        }
        // Console.WriteLine();
    }
    Console.Write("]");
}