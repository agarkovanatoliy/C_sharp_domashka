// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[] GetArray(int size,int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();

    }
    return res;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void DifferenceMaxMin(double[] arr)
{
    double result = 0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    result = max - min;
    Console.WriteLine($"Разница между max и min элементами равна: {result}");
}


int size = Prompt("Введите длину массива: ");
int minValue =Prompt("Введите начальное значение для дипазона случайных чисел: ");
int maxValue =Prompt("Введите конечное значение для дипазона случайных чисел: ");
double[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
DifferenceMaxMin(array);

