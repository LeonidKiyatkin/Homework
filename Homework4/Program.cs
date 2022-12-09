//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// Console.Clear();
// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите степень: ");
// int B = int.Parse(Console.ReadLine());

// Console.WriteLine($"{A} в степени {B} = {Pow(A,B)}");


// int Pow(int num, int rank)
// {
//     if(B==0) 
//     return 1;

//     int result = num;
//     for (int i = 2; i <= rank; i++)
//     {
//         result *= num;
//     }
//     return result;
// }


//Напишите программу, которая принимает 
//на вход число N и выдаёт сумму цифр в числе.
// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Суммф цифр = {GetSumNums(num)}");


// int GetSumNums(int number)
// {
//     int sum = 0;
//     while(number>0)
//     {
//         sum+=number%10;
//         number/=10;
//     }
//     return sum;
// }


// //Напишите программу, которая задаёт массив 
// //из 8 элементов и выводит их на экран.
Console.Clear();
int[] array = GetRandomArray(8,0,100);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }

    return result;
}