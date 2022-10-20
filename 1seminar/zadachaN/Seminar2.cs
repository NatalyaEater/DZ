// Определить номер четверти,в которой находится точка с координатами х и у,причем х не равен 0,и у не равен нулю
Console.Clear();
Console.WriteLine("Введите X ");
int X = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите Y ");
int Y = int.Parse(Console.ReadLine() ?? "0");
if (X>0)
    if (Y>0)
Console.WriteLine("Первая четверть");
    else 
     Console.WriteLine("Четвертая четверть");
else 
    if (Y >0)
    Console.WriteLine("Вторая четверть");
    else 
     Console.WriteLine("Третья четверть");
