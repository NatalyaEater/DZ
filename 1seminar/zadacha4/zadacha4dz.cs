﻿Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberE = int.Parse(Console.ReadLine());
int max = numberA;
if (numberA>max)
{
    max = numberA;
}
if(numberB>max)
{
    max = numberB;
}
if(numberE>max)
{
    max = numberE;
}
 Console.WriteLine(max);