// Программа проверяет пятизначное число на палидром
Console.Clear();
Console.WriteLine("Введите пятизначное число ");
int fivenumber = int.Parse(Console.ReadLine() ?? "0");
int numberA =(fivenumber/10000)%10;//первое число
int numberB =(fivenumber/1000)%10;//второе число
int numberC=(fivenumber/10)%10;//четвертое число
int numberD= fivenumber%10;//пятое число

if ((fivenumber>10000)&&(fivenumber<99999))
{
    if ((numberA == numberD)||(numberB == numberC))
    {
   Console.WriteLine("Данное число палидром ");
    }
    else
    {
Console.WriteLine("Данное число НЕ палидром ");
    }
}
else
{
Console.WriteLine("Число не соответствует условию ");
}
