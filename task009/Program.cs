// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Задайте число: ");
int numberToCheck = int.Parse(Console.ReadLine());
Console.Write("Кратность какому числу нужно проверить: ");
int checkingNumber = int.Parse(Console.ReadLine());

if (numberToCheck % checkingNumber == 0)
{
    Console.WriteLine($"Число {numberToCheck} - кратно числу {checkingNumber} ");
}
else
{
    Console.WriteLine($"Число {numberToCheck} - не кратно числу {checkingNumber} ");    
}
