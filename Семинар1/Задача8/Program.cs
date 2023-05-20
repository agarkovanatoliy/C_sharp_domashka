// Написать программу которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N  

Console.Write("Введите положительное число: ");
int a = int.Parse(Console.ReadLine());

if ( a < 0 )
{
    Console.Write("Неверное чило! ");
}
else
{
    int b = 2;
    while ( b <= a)
    {
    Console.Write( b + "," );
    b = b + 2; 
    }
}