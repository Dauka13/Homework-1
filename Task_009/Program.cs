// Удалить вторую цифру трёхзначного числа

Console.Clear();
int Number = new Random().Next(100, 1000);
int NewNumber = 0;
int LeftNumber()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}
LeftNumber();
System.Console.WriteLine();
System.Console.WriteLine($"{Number} итог {NewNumber}");