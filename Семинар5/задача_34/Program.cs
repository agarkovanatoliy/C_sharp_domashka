// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.


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

bool ValidateExponent(int arg)
{
    if (arg < 0)
    {
        Console.WriteLine("показатель не должен быть меньше нуля");
        return false;
    }
    else if (arg < 100 && arg > 999)
    {
        Console.WriteLine("показатель должен быть трехзначным");
        return false;
    }
    return true;
}


void EvenNumber(int[] arr)
{
    int result = 0;
    foreach (int el in arr)
    {
        if ( el%2 == 0 ) result ++;
    }
    Console.WriteLine ($"Количество четных элементов равно: {result}");
}



int size = Prompt("Введите длину массива: ");
int minValue =Prompt("Введите начальное трехзначное значение для дипазона случайных чисел: ");
int maxValue =Prompt("Введите конечное трехзначное значение для дипазона случайных чисел: ");
//  if  (ValidateExponent(minValue) == true || ValidateExponent(maxValue) == true) 
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
EvenNumber(array);