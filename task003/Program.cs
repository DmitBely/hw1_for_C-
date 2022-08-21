// Найти максимальное из трех чисел

Console.Write("Введите последовательно три числа: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Теперь второе: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Теперь третье: ");
int third = int.Parse(Console.ReadLine());

int max = first;

if (second >= max)
{
    max = second;
}
else
{
    max = first;
}

if (third >= max)
{
    max = third;
}

Console.WriteLine($"Максимальное число = {max}");