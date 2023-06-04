// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int Exponentiation(int poverBase, int exsponent)
{
    int reselt = 1;
    for (int i = 0; i < exsponent; i++)
    {
        reselt *= poverBase;
    }
    return reselt;
} 

int poverBase = Prompt("Введите основание: ");
int exponent = Prompt("ВВедите покозатель степени:");

if (ValidateExponent(exponent)) Console.WriteLine($"Число {poverBase} в степени {exponent} равно {Exponentiation(poverBase, exponent)}");