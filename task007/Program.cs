// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Write("Введите число от 10 до 99: ");
int number = int.Parse(Console.ReadLine());



if ((number > 99) ^ (number < 10))
{
    Console.Write("Число за пределами 10 и 99");
}
else
{
    int firstN = number / 10;
    int secondN = number % 10;
    int max = firstN;

    if(secondN > firstN)
    {
        max = secondN;
        Console.WriteLine($"Максимальная цифра в этом числе это {max}");
    } 
    else if (secondN < firstN)
    {
        Console.WriteLine($"Максимальная цифра в этом числе это {max}");
    }
    else
    {
       Console.WriteLine("Числа равны"); 
    }
}