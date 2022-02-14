// Найти кубы чисел от 1 до N

int GetRandomNumber()
{
    int numberR = new Random().Next(1, 50);
    Console.WriteLine($"Число: {numberR}");
    return numberR;
}
int rNumber = GetRandomNumber();

for (int i = 1; i < rNumber; i++)

{
    int result =(int)Math.Pow((i+1),3);
    Console.WriteLine($"{i}^3 = {result}");
}