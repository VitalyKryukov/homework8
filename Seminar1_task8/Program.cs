// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.Clear();

Console.WriteLine("Введите число (N): ");
int number = int.Parse(Console.ReadLine());

//Вариант 1. Только для положительных чисел.
// for (int count = 1; count <= number; count++)
// if (count % 2 == 0)
// Console.Write(count + ", ");

//Вариант 2. Для положительных чисел.
// int count = 1;
// while (count <= number)
// {
//     if (count % 2 == 0)
//     {
//         Console.Write(count + ", ");
//         count++;
//     } 
//     else
//     {
//         count++;
//     }
// }

//Вариант 3. Для положительных и отрицательных чисел.
int count = 1;
if (number > 0)
{
    while (count <= number)
    {
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count++;
    }
}

else
{
     while (count >= number)
    {
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count--;
    }
}

