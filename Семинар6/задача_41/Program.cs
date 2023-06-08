// Задача 41: Пользователь вводит с клавиатуры M
// чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


string Prompt(string message)
{
    Console.Write(message);
    string num = Console.ReadLine();
    return num;
}


void SumNumber()
{
    int sum = 0;
    int temp = 0;
    while (sum >= 0)
    {    
        // Array.Resize(ref res, res.Length + 1); 
        string number = Prompt("Введите число или нажмите клавишу Q: ");
        if (number.ToLower() == "q") break;     
        else temp = int.Parse(number);
        if (temp > 0) sum++;
    }
    Console.WriteLine($"Пользователь ввел {sum} положительных чисела!");
}

SumNumber();
