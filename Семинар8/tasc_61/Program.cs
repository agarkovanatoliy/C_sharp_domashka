// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника

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


void FillTriangle(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < triangle.GetLength(0); i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintPascalTriangle(int[,] triangle)
{
    const int cellWidth = 3;  // при выведении больше 20 строк константу нужно увеличивать
    int col = cellWidth * triangle.GetLength(0);
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.WriteLine($"{triangle[i, j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * triangle.GetLength(0) - cellWidth * (i + 1);

        Console.WriteLine();
    }
}


int row = Prompt("Ведите число строк треугольника: ");
int[,] triangle = new int[row, row];

FillTriangle(triangle);
PrintPascalTriangle(triangle);
