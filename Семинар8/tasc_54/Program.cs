// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.


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

int[,] ArrangingMatrixRows(int[,] matrix)
{
    int[,] result = matrix;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            int maxPosition = j;
            for (int n = j + 1; n < matrix.GetLength(1); n++)
            {
                if (matrix[i, n] > matrix[i, maxPosition]) maxPosition = n;
            }
            int tempmatr = result[i, j];
            result[i, j] = result[i, maxPosition];
            result[i, maxPosition] = tempmatr;

        }
    }
    return result;
}



int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
int[,] matr = CreateRandomMatrix(row, col, from, to);
PrintMatrix(matr);
Console.WriteLine();
int[,] matr1 = ArrangingMatrixRows(matr);
PrintMatrix(matr1);