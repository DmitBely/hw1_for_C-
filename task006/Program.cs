// Показать вторую цифру трёхзначного числа

Console.Write("Введите трёхзначное число ");
int number = int.Parse(Console.ReadLine());

int step1 = number % 100;
int step2 = step1 / 10;

Console.Write($"Вторая цифра трёхзначного числа это  {step2}");
