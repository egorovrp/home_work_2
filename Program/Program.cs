// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int n = int.Parse(Console.ReadLine()!);
int SecondNumber = 0;

if(n > 100 && n < 1000)
{
SecondNumber = (n / 10) % 10;
Console.WriteLine("Вторая цифра числа: " + SecondNumber);
}
else
{Console.WriteLine("Число не трёхзначное!");
}