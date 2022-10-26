// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Main();

//Методы

void Main()
{
    Console.WriteLine("Start");
    double b1 = 0, k1 = 0, b2 = 0, k2 = 0;
    WriteVariable(ref b1, ref k1, ref b2, ref k2);
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {PointIntersectionLines(b1, k1, b2, k2)}"); 
    //PointIntersectionLines(b1, k1, b2, k2);
    //Console.WriteLine(")");
    Console.WriteLine("End");
}

void WriteVariable(ref double b1, ref double k1, ref double b2, ref double k2)
{
    Console.WriteLine("Введите значение b1: ");
    b1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k1: ");
    k1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение b2: ");
    b2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите значение k2: ");
    k2 = double.Parse(Console.ReadLine()!);
}

//                              b1      k1      b2      k2
// void PointIntersectionLines(double a1, double b1, double a2, double b2)
// {
//     if(b1 == b2) Console.Write("Прямые не пересекаются и параллельны друг другу.");
//     else
//     {
//         // y = k1 * x + b1
//         // y = k2 * x + b2
//         // k1 * x + b1 = k2 * x + b2
//         // k1 * x - k2 * x = - b1 + b2
//         // (k1-k2) * x = - b1 + b2
//         // x = (- b1 + b2) / (k1 -k2)
//         double x = (- a1 + a2) / (b1 - b2);
//         double y = b1 * x + a1;
//         Console.Write($"{x},{y}; {x},{y}");
//     }
// }

string PointIntersectionLines(double a1, double b1, double a2, double b2)
{
    if(b1 == b2) return "Прямые не пересекаются и параллельны друг другу.";
    else
    {
        double x = (- a1 + a2) / (b1 - b2);
        double y = b1 * x + a1;
        return $"({x}; {y})";
    }
}

