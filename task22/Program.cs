// Найти расстояние между точками в пространстве 2D/3D

string space = "";

while (space.ToLower() != "2d" || space.ToLower() != "3d")
{
    Console.WriteLine("Выбрать пространство 2d или 3d:");
    space = Console.ReadLine();
    if (space.ToLower() == "2d" || space.ToLower() == "3d")
       break;
}
double GetPoint()
{
    Console.WriteLine("Введите координаты точки ");
    string numberStr = Console.ReadLine();
    double number = int.Parse(numberStr);
    return number;
}
if (space.ToLower() =="2d")
{
    double x = GetPoint();
    double y = GetPoint();
    Console.WriteLine($"Первая точка: ({x}, {y})");
    double x1 = GetPoint();
}
if (space.ToLower() == "3d")
{
    double x = GetPoint();
    double y = GetPoint();
    double z = GetPoint();
    Console.WriteLine($"Первая точка: ({x}, {y}, {z})");
    double x1 = GetPoint();
    double y1 = GetPoint();
    double z1 = GetPoint();
    Console.WriteLine($"Вторая точка: ({x1}, {y1}, {z1})");

    double distance1 = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow ((y1 - y),2)+ Math.Pow ((z1 -z ),2));
    Console.WriteLine($"Расстояние между точками: {distance1}");
}
else
    Console.WriteLine("Ошибка");
