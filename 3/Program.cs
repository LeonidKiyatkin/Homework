// принимает число и выдает четное ли оно

//Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");

}
else
{
    Console.Write("Число нечетное");
}