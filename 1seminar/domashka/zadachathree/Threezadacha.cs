﻿// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.WriteLine("Ввведите число четверти координат");
int number = int.Parse(Console.ReadLine());
if (number>0 &&number<5)
{
if (number==1)
{
    Console.WriteLine("Координаты должны находится в следующих значениях:x=[0;+бесконечности ]  y=[0;+бесконечности]");
}
if (number==2)
{
    Console.WriteLine("Координаты должны находится в следующих значениях:x=[0;-бесконечности]  y=[0;+бесконечности]");
 }
if (number==3)
{
    Console.WriteLine("Координаты должны находится в следующих значениях:x=[0;-бесконечности]  y=[0;-бесконечности]");
 }
if (number==4)
{
    Console.WriteLine("Координаты должны находится в следующих значениях:x=[0;+бесконечности]  y=[0;-бесконечности]");
 }
}
else 
{
    Console.WriteLine("Введите число от 1 до 4");
}