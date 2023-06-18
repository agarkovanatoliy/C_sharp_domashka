// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

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

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i, j, k]} [{i},{j},{k}]");
            }
        }
        Console.WriteLine();
    }
}

void CreateRandomMatrix(int[,,] matrix3D)
{
    int[] temp = new int[matrix3D.Length];
    int tempNumber;
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        tempNumber = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    tempNumber = temp[i];
                }
            }
        }
    }
    int count = 0;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i,j,k] = temp[count];
                count ++;
            }
        }
    }
}



int row = Prompt("Ведите розмер массива: ");
int col = Prompt("Ведите розмер массива: ");
int list = Prompt("Ведите розмер массива: ");
if (row * col * list > 90) Console.WriteLine("Введите другие числа!");
int[,,] matr = new int[row, col, list]; 
CreateRandomMatrix(matr);
PrintMatrix(matr);

