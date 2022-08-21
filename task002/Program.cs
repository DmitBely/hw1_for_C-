// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели от 1 до 7: ");
int dayWritten = int.Parse(Console.ReadLine());

if (dayWritten == 1)
{
    Console.WriteLine("Monday");
}

else if (dayWritten == 2)
{
    Console.WriteLine("Tuesday");
}

else if (dayWritten == 3)
{
    Console.WriteLine("Wednesday");
}

else if (dayWritten == 4)
{
    Console.WriteLine("Thursday");
}

else if (dayWritten == 5)
{
    Console.WriteLine("Friday");
}

else if (dayWritten == 6)
{
    Console.WriteLine("Saturday");
}

else if (dayWritten == 7)
{
    Console.WriteLine("Sunday");
}

else
{
    Console.WriteLine("I don't know suuch day");
}
