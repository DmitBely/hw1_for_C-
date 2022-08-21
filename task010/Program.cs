// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string stringed = number.ToString();

Console.WriteLine(stringed);

if (stringed[2] != null)
{
    Console.WriteLine($"Третий символ {stringed[2]}");    
}
else
{
    Console.WriteLine("Третьего символа нет"); 
}
