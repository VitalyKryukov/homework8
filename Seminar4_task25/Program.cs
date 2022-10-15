// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Main();

// МЕТОДЫ:
//Основной метод
/*void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine("Введите число A: ");
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int B = int.Parse(Console.ReadLine());
    Console.WriteLine($"{A} в степени {B} = {MetodPow(A, B)}");
    Console.WriteLine("End");
}*/

//Метод возведения числа A в степень B.
int MetodPow(int number, int power)
{
    // int result = Math.Pow(Number,Power);
    // return result; 
    int result = 1;
    for(int i = 0; i < power; i++)
    {
        result = result*number;
    }
    return result; 
}

void Main()
{
    int A = 0, B = 0;
    WriteVariable(ref A, ref B); // ref -- передаёт переменные по ссылке и работает непосредственно с ними (не с копией, как в обычном случае)
    Console.WriteLine($"{A} в степени {B} = {MetodPow(A, B)}");
    Console.WriteLine("End");
}

void WriteVariable(ref int A, ref int B)
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine("Введите число A: ");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    B = int.Parse(Console.ReadLine());
}


