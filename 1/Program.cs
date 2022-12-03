Console.Clear ();
Console.WriteLine ("Введите первое число (А):");
int number1 = int.Parse(Console.ReadLine ());
Console.WriteLine ("Введите второе число (B):");
int number2 = int.Parse(Console.ReadLine ());

if (number1 > number2)
{
    Console.WriteLine ("А больше В");
    }
    else
    if (number1 < number2)
    {
        Console.WriteLine ("А меньше В");
            }
    else
    {
        Console.WriteLine ("А равно В");
    }
