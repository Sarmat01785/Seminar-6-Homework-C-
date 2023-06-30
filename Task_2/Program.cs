//                                   Задача 43:
//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNum(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine()!);
}

void IntersectionPoint(double b1, double k1, double b2, double k2) // метод поиска пересечения двух прямых.
{
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают.");
    else if (k1 == k2)
        Console.WriteLine("Прямые параллельные.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых x = {x}, y = {y}");
    }
}
double coordinatesB1 = InputNum("Введите координаты b1: ");
double coordinatesK1 = InputNum("Введите координаты k1: ");
double coordinatesB2 = InputNum("Введите координаты b2: ");
double coordinatesK2 = InputNum("Введите координаты k2: ");
IntersectionPoint(coordinatesB1, coordinatesK1, coordinatesB2, coordinatesK2);

