// проверить число на кратность 7 и 23
Console.Clear();
Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int ostatok = numberA%7;
int ostatok2 = numberA%23;
if ((ostatok==0)||(ostatok2==0))
{
    Console.WriteLine("Кратно");
}
else 
{
     Console.WriteLine("НЕкратно");
}