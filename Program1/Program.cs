// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);
int ThreeNumber = 0;

if (n/100 > 0)
{
ThreeNumber = (n%1000 - n%100)/100;
Console.WriteLine(ThreeNumber);
}
else
{
Console.WriteLine("Третьей цифры нет!");
}