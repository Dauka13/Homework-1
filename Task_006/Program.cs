// Показать последнюю цифру трёхзначного числа

Console.Clear();
int number = new Random().Next(100, 1000);
int a = number % 10;
Console.WriteLine("Число: " + number);
Console.WriteLine("Последняя цифра трехзначного числа: " + a);