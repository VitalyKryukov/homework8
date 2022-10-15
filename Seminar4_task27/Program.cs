// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Main();

// МЕТОДЫ:
// 
void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine($"Сумма цифр в числе {number} = {SumDigits(Math.Abs(number))}.");
    Console.WriteLine("End");
}

int SumDigits(int number)
{
    int result = 0;
    // Console.WriteLine((int) (number / Math.Pow(10,0)));
    for(int i = 0; ; i++)
    {
        int currentNumber = (int) (number / Math.Pow(10,i)); //(int) - переводит дробное число в целое число (отбрасывает дробную часть)
        if(currentNumber == 0)
        {
            break;
        }
        int currentDigits = currentNumber % 10;//
        // Console.WriteLine(currentDigits);
        result += currentDigits;
        // int a1 = num / 10^2 %10;
        // int a2 = num /10^1 % 10;
        // int a3 = num  % 10;

    }
    return result;
}

