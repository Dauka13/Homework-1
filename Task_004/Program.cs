// Выяснить является ли число чётным

Console.Clear();
int i;
Console.Write("Введите число: ");
i = int.Parse(Console.ReadLine());
if (i%2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}