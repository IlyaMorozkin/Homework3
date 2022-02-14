// Задать номер четверти, показать диапазоны для возможных координат

int number = 0;
while (number > 4 || number < 1)
{
    Console.WriteLine("Введите номер четверти от 1 до 4: ");
    string numberStr = Console.ReadLine();
    number = int.Parse(numberStr);
}
if (number == 1)
    Console.WriteLine("Диапозон 1 четверти: x = (0, +oo) y = (0, +oo)");
if (number == 2)    
    Console.WriteLine("Диапозон 2 четверти: x = (-oo, 0) y = (0, +oo)");
if (number == 3)
    Console.WriteLine("Диапозон 3 четверти: x = (-oo, 0) y = (-oo, 0)");
if (number == 4)
    Console.WriteLine("Диапозон 4 четверти: x = (0, +oo) y = (-oo, 0)");        