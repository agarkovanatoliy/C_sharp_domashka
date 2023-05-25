// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа

// Console.Write("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine());

// if (number < 100 || number > 999)
// {
//     Console.Write("Неверное число! ");
// }
// else
// {
//     number = number / 10;
//     number = number % 10;
//     Console.Write(number);
// }

void SecondDigit(int arg)
{
    if (arg < 100 || arg > 999)
    {
        Console.Write("Неверное число! ");
    }
    else
    {
        arg = arg / 10;
        arg = arg % 10;
        Console.Write(arg);
    }
}

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
SecondDigit(number);