// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomMatrix(int rows, int colums, int from, int to)
{
    int[,] matrix = new int[rows, colums];
    to++;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(from, to);
        }
    }
    return matrix;
}

int[] SumLinesMatrix(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        result[i] = summ;
    }
    return result;
}

void MinSumLinesMatrix(int[,] matrix, int[] arr)
{
    int minPosition = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[minPosition]) minPosition = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов является: {minPosition + 1}, сумма равна: {arr[minPosition]}");
    Console.WriteLine();
    Console.Write("Значение элементов этой строки следующие: ");

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($" {matrix[minPosition, j]}");
    }


}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
int[,] matr = CreateRandomMatrix(row, col, from, to);
PrintMatrix(matr);
Console.WriteLine();
int[] array = SumLinesMatrix(matr);
MinSumLinesMatrix(matr, array);