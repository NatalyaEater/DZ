// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Ввведите первое число ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Ввведите второе число ");
int numberB = int.Parse(Console.ReadLine());

int kvadratA =numberA*numberA;
int kvadratB =numberB*numberB;

if (numberA==kvadratB)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
 if (numberB==kvadratA)
 {
Console.WriteLine("Второе число является квадратом первого числа ");
 }
if ((numberA!=kvadratB) && (numberB!=kvadratA))
{
Console.WriteLine("Данные числа не являются парными  ");
}