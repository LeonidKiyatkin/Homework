// принимает число и показывает все четные от 1 до этого числа.

Console.Clear();
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= N)
{
   if (i % 2 == 0)
   {
       Console.WriteLine($"{i}");
    }
    i++;
}
Console.WriteLine();



