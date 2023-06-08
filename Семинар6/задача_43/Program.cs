// Задача 43 Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4,
// k2 = 9 -> (-0,5; -0,5)




double Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((double.TryParse(value, out double val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void IntersectionPoint(double k1, double k2, double b1, double b2)
{
    double x = 0;
    double y = 0;
    x = (b1-b2)/(k2-k1);
    y = k1*x + b1;
    Console.WriteLine($" Точка пересечения прямых (x, y) равна: ({x}, {y}) ");
}

double k1 = Prompt("Введите число к1: ");
double k2 = Prompt("Введите число к2: ");
double b1 = Prompt("Введите число b1: ");
double b2 = Prompt("Введите число b2: ");
IntersectionPoint(k1, k2, b1, b2);