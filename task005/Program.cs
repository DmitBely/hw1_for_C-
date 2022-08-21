// Показать четные числа от 1 до N

Console.Write("Введите число до которого нужно вывести чётные: ");
int number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i += 2) Console.WriteLine(i);
