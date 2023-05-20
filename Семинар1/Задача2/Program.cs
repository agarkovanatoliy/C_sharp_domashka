// Написать программу которая на вход принимает 2 числа и выдает,какое число бльшее, а какое меньшее

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if ( a > b )
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("max = " + max + "; min = " + min);