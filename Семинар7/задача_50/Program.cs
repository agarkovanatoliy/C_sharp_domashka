// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец


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

int[,] CreateMRandoMatrix(int rows, int colums, int from, int to)
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

void ArrayItem(int[,] matrix, int arg1, int arg2)
{
    if (arg1 >= matrix.GetLength(0) || arg2 >= matrix.GetLength(1))
    {
        Console.WriteLine($"Элемента стоящего на позиции [{arg1}, {arg2}] нет!");
    }
    else
    {
        Console.WriteLine($"Элемент стоящий на позиции [{arg1}, {arg2}] равен: {matrix[arg1, arg2]}");
    }
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
int[,] matr = CreateMRandoMatrix(row, col, from, to);
PrintMatrix(matr);
int line = Prompt("Ведите номер строки массива: ");
int column = Prompt("Введите номер столбца массива: ");
ArrayItem(matr, line, column);