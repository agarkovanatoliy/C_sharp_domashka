// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void SumOddPositions(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( i%2 != 0) result += arr[i];
    }
    Console.WriteLine($"Сумма элементов стоящих на нечетной позиции равна: {result}");
}

int size = Prompt("Введите длину массива: ");
int minValue =Prompt("Введите начальное трехзначное значение для дипазона случайных чисел: ");
int maxValue =Prompt("Введите конечное трехзначное значение для дипазона случайных чисел: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
SumOddPositions(array);