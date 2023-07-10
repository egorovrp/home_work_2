// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);
int ThreeNumber = 0;
if(n>100){
while (n >= 1000)
{
n = n / 10;
}
Console.WriteLine(n % 10);
}
else
{
Console.WriteLine("Третьей цифры нет!");
}