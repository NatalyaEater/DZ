Console.Clear();
Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int ostatok = numberA%2;
if (ostatok==0)
{
    Console.WriteLine("Четное");
}
else 
{
     Console.WriteLine("Нечетное");
}