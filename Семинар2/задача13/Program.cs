// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// if ( number < 100)
// {
//     Console.WriteLine("Третьего числа нет! ");
// }
// else
// {
//     while ( number > 999)
//     {
//         number = number / 10;
//     }
//     number = number % 10;
//     Console.WriteLine("Третьего число: " + number);
// }

void ThirdDigit(int arg)
{
    if ( arg < 100)
    {
        Console.WriteLine("Третьего числа нет! ");
    }
    else
    {
        while ( arg > 999)
        {
            arg = arg / 10;
        }
        arg = arg % 10;
        Console.WriteLine("Третьего число: " + arg);
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
ThirdDigit(number);