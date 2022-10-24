// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Main();

//Методы

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine("Сколько чисел Вы планируете ввести?");
    int quantity = int.Parse(Console.ReadLine()!);
    int[] array = ArrayNumbers(quantity);
    PrintArrayNumbers(array);
    Console.WriteLine($" -> {CountPositiveNumbers(array)}");
    Console.WriteLine("End");
}


int[] ArrayNumbers(int size)
{
    Console.WriteLine("Введите числа: ");
    int[] arrayM = new int[size];
    for (int i = 0; i < size; i++)
    {
        try
        {
        arrayM[i] = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Введено некорректное значение!");
        }
    }
    return arrayM;
}


void PrintArrayNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) Console.Write(", ");
    }   
}

int CountPositiveNumbers(int[] inArray)
{
    int result = 0;
    foreach (int el in inArray)
    {
        if (el > 0)
        {
            result += 1;
        }
    }
    return result;
}