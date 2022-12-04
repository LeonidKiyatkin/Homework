//принимает три числа и выдет максимальное

Console.WriteLine ("ВВедите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("ВВедите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("ВВедите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"Максимальное число {max}");