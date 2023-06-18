// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] MultiplyingMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                result[i,j] += matrix1[i,n]*matrix2[n,j];
            }
        }
    }
    return result;
}



int row = Prompt("Ведите розмер квадратного двумерного массива количество строк = количеству столбцов: ");
int col = row;
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
int[,] matr1 = CreateRandomMatrix(row, col, from, to);
int[,] matr2 = CreateRandomMatrix(row, col, from, to);
PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine("Произведение этих матриц равно:");
int[,] matr3 = MultiplyingMatrix(matr1, matr2);
PrintMatrix(matr3);