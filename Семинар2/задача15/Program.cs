// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.



string[] weekday = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int length = weekday.Length;
int index = 0;
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Неверное число! ");
}
else if (number >= 1 & number <= 5)
{
    index = number - 1;
    Console.WriteLine( weekday[index] + ",  рабочий день!");
}
else if ( number == 6 || number == 7)
{
    index = number - 1;
    Console.WriteLine( weekday[index] + ",  выходной день!");
}