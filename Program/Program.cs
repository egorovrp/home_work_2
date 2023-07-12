// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


void SearchSecondNumber(int num)
{
    int SearchNumber = 0;
    if(num > 100 && num < 1000)
    {
    SearchNumber = (num / 10) % 10;
    Console.WriteLine("Вторая цифра числа: " + SearchNumber);
    }
    else
    {
    Console.WriteLine("Число не трёхзначное!");
    }
}

Console.WriteLine("Введите трехзначное число:");
int n = int.Parse(Console.ReadLine()!);
SearchSecondNumber(n);
