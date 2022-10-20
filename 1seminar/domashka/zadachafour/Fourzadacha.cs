// Найти расстояние между точками в пространстве 2D
Console.Clear();
Console.WriteLine("Введите значение координаты Х1");
int x1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите значение координаты Х2");
int x2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите значение координаты У1");
int y1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите значение координаты У2");
int y2 = int.Parse(Console.ReadLine() ?? "0");
double distance = Math.Sqrt(((x2-x1)^2) + ((y2-y1)^2));
Console.WriteLine(distance);
