// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

int Prompt (string message)
{
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

void CalcDist (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double d = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(x1-x2) + (z1-z2)*(z1-z2));
    Console.WriteLine("Расстояние между точками: "+d);
}


int x1 = Prompt ("Введите координату X точки A: ");
int y1 = Prompt ("Введите координату Y точки A: ");
int z1 = Prompt ("Введите координату Z точки A: ");

int x2 = Prompt ("Введите координату X точки B: ");
int y2 = Prompt ("Введите координату Y точки B: ");
int z2 = Prompt ("Введите координату Z точки A: ");

CalcDist(x1, y1, z1, x2, y2, z2);