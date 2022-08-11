// Удалить вторую цифру трёхзначного числа

Console.Clear();
int n = int.Parse(Console.ReadLine() ?? "0");
if (n >= 100 && n < 1000)
{
    int last = n % 10;
    int first = n / 100;
    int result = first * 10 + last;
    Console.WriteLine("Число с удалённой второй цифрой: " + result);
}
else
    Console.WriteLine("Это не трёхзначное число");