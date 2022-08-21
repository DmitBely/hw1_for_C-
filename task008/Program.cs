// Удалить вторую цифру трёхзначного числа

Console.Write("Введите трёхзначное: ");
int number = int.Parse(Console.ReadLine());

int firtstN = number / 100;
int secondN = (number % 100) / 10;
int thirdN = number % 10;

int newNumber = int.Parse(firtstN.ToString() + thirdN.ToString());

Console.WriteLine($"Новое число это {newNumber}");
