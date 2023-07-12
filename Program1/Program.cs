// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


void ThreeNumber(int n)
{
    if(n>100)
    {
        while (n >= 1000)
        {
        n = n / 10;
        }
        Console.WriteLine("Третья цифра числа: " + (n % 10));
    }
    else
    {
    Console.WriteLine("Третьей цифры нет!");
    }
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
ThreeNumber(num);
