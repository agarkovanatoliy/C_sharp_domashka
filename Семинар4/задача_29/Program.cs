// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

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

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int size = Prompt("Введите длину массива: ");
int minValue =Prompt("Введите начальное значение для дипазона случайных чисел: ");
int maxValue =Prompt("Введите конечное значение для дипазона случайных чисел: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);