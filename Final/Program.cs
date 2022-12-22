// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



Console.Write("Количество элементов массива: ");
int Length = Convert.ToInt32(Console.ReadLine());

string[] arrayin = new string[Length];
for (int i = 0; i < Length; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    arrayin[i] = element;
}

string[] arrayout = new string[Length];
int n = 3;
int pos = 0;

for (int j = 0; j < Length; j++)
{
    if (arrayin[j].Length <= n)
    {
        arrayout[pos] = arrayin[j];
        pos++;
    }
}

Console.WriteLine();
Console.WriteLine("Элементы массива <= 3 символам:");
PrintArray(arrayout);