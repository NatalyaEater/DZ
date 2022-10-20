Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = int.Parse(Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine("Максимальное "+ numberA + "  Минимальное"+numberB);
}
else 
{
     Console.WriteLine("Максимальное "+ numberB + "  Минимальное "+numberA);
}