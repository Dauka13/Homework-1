// Показать числа от -N до N

Console.Clear();
Console.Write("Введите число: ");
string writeNumber = Console.ReadLine();
int endNumber = int.Parse(writeNumber);
int Number = endNumber * -1;
Console.Write($"{Number} ");
while (Number < endNumber)
{
    Number++;
    Console.Write($"{Number} ");
}