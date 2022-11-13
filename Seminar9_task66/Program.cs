// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Main();

void Main()
{
    Console.WriteLine("Start");
    Console.Write("Введите M: ");
    int M = int.Parse(Console.ReadLine());
    Console.Write("Введите N: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine($"M = {M}; N = {N} -> {Sum(M,N)}");
    Console.WriteLine("End");
}

int Sum(int from, int to)
{
    int sum = 0;

   
    if(from > to)
    {
        int temp = to;
        to = from;
        from = temp;
    }

    for(int i = from; i <= to; i++)
    {
        sum += i;
    }
    return sum;
}