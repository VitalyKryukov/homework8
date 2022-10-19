// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Main();

// МЕТОДЫ:
//
void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    double [] array = GetArray(new Random().Next(5,5));
    Console.WriteLine("Полученный массив: ");
    PrintArray(array);
    Console.WriteLine($"Разница между максимальным и минимальным эллементом массива равна {DifferenceMaxMinInArray(array)}.");
    Console.WriteLine("End");
}

double [] GetArray(int size)
{
    double [] res = new double[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1,100) + Math.Round(new Random().NextDouble(),2);
    }
    return res;
}

void PrintArray(double [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != array.Length - 1)
        {
             Console.Write(" | ");
        }
    }
    Console.Write("]\n");
}

double DifferenceMaxMinInArray(double [] array)
{
    double min = Double.MaxValue;
    double max = Double.MinValue;
    foreach(double el in array)
    {
       if(el>max) max = el;
       if(el<min) min = el;
    }
    return Math.Round(max - min,2);
}