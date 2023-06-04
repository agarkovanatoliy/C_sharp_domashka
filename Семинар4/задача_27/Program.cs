// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Sum (int num)
{
    int result = 0;
    while ( num > 0)
    {
        result += num%10;
        num = num /10;
    }
    return result;
}

int number = Prompt("Введите число: ");
int sum = Sum(number);
Console.WriteLine($"Сумма цыфр в числе {number} равна: {sum}");