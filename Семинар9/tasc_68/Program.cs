// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    Console.Clear();
    return val;
}


int AckermanFunction(int m, int n)
{    
    if(m == 0) return n + 1;
    else if (m>0 && n==0) return AckermanFunction(m-1, 1);
    else  return AckermanFunction(m-1,AckermanFunction(m,n-1));
}

int number1 = Prompt("Введиче число m: ");
int number2 = Prompt("Введиче число n: ");
int function  = AckermanFunction(number1, number2);
Console.Write(function);