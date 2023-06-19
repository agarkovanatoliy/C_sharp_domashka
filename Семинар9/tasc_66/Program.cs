// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


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


int SumNaturalNumber(int numb1, int numb2, int sum)
{    
    if (numb1 <= numb2)
    {        
        sum += numb1;
        return SumNaturalNumber(numb1+1, numb2, sum);
    }
    else return sum;
}

int number1 = Prompt("Введиче число: ");
int number2 = Prompt("Введиче число: ");
int summ = 0;
int summ1  = SumNaturalNumber(number1, number2, summ);
Console.Write(summ1);