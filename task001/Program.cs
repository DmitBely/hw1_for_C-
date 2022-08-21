// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());

int square = x * x;

if(square == y)
{
    Console.WriteLine($"Число {y} это квадрат числа {x}");
}
else
{
    Console.WriteLine($"Число {y} это не квадрат числа {x}");
}

