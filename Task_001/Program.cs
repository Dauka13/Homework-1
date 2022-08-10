// По двум заданным числам проверить является ли первое квадратом второго

Console.Clear();
Console.WriteLine("Введите первое число: ");
string writeNumber1 = Console.ReadLine();
int number1 = int.Parse(writeNumber1);

Console.WriteLine("Введите второе число: ");
string writeNumber2 = Console.ReadLine();
int number2 = int.Parse(writeNumber2);

string Result = $"Число {number1} не является квадратом числа {number2}";     
if (number1 == number2 * number2)               
{
    Result = Result.Replace(" не", "");  
}
Console.WriteLine(Result);