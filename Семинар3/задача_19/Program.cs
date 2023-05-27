// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

int Prompt (string message)
{
    Console.Write(message);
   int num =  int.Parse(Console.ReadLine());

    if (num < 10000 || num > 99999)
    {
        Console.WriteLine("Неверное число!");  
    }
return num;
}

void Polyndrome(int arg)
{
    int a = arg / 10000;
    int a1 = arg % 10;
    int temp = arg / 1000;
    int b = temp % 10;
    int temp1 = arg / 10;
    int b1 = temp1 % 10;
    // Console.WriteLine(a + ", " + a1 + ", " + b + ", "  + b1 );
    if ( a == a1 & b == b1)
    {
        Console.WriteLine("Это число является полиндромом!");
    }
    else
    {
        Console.WriteLine("Это число не является полиндромом!");
    }
}


int num = Prompt ("Введите 5-ти значное число: ");
Polyndrome(num);