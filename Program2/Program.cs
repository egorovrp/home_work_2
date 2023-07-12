// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


void WorkDay(int Day)
{
    if(Day <= 5 && Day >= 1 )
    {
    Console.WriteLine("День не является выходным!");
}
    else
    {
    if (Day > 5 && Day <= 7)
        {
        Console.WriteLine("День является выходным!");
        }
    else
        {
        Console.WriteLine("Error: Введите число от 1 до 7!");
        }
    }
}

Console.WriteLine("Введите цифру дня недели:");
int WhyDay = int.Parse(Console.ReadLine()!);
WorkDay(WhyDay);