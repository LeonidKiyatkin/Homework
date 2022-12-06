// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 && num < 1000)
// {
//     int secondNumber = (num / 10) % 10;

//     Console.WriteLine($" Вторая цифра в числе {num} -> {secondNumber}");
// }
// else
//     Console.WriteLine("Вы ввели не трехзначное число");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


//это я пытался сам и запутался...
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
//  {

//       if (num < 100)
//      {
//         Console.WriteLine($"Третьей цифры нет");
//     
//          }
//     int thirdNumber = (num / 10) % 10;
         
//    Console.WriteLine($"Третья цифра {num} -> {thirdNumber}");
 //}

// решение с семинара
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Какую цифру показать?:");
// int index = Convert.ToInt32(Console.ReadLine());

// double pow = Math.Pow(10, index);

// if (num < pow/10)
// {
//    Console.WriteLine($"такой цифры там нет");

// }
// else
// {
// int tmp = num;

// while (tmp > pow)
// {
//    tmp /= 10;
// }
// int result = tmp % 10;

// Console.WriteLine($"указанная цифра от числа {num} -> {result}");

// }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите день недели числом (1-7), и я скажу выходной ли это: ");
// int day = Convert.ToInt32(Console.ReadLine());
// switch (day)
// {
//    case 1:
//    Console.WriteLine("Понедельник - нет");
//    break;
//    case 2:
//    Console.WriteLine("Вторник - нет");
//    break;
//    case 3:
//    Console.WriteLine("Среда - нет");
//    break;
//    case 4:
//    Console.WriteLine("Четверг - нет");
//    break;
//    case 5:
//    Console.WriteLine("Пятница - нет");
//    break;
//    case 6:
//    Console.WriteLine("Суббота - да");
//    break;
//    case 7:
//    Console.WriteLine("Воскресенье - да");
//    break;
//    default:
//    Console.WriteLine("такого дня недели нет");
//    break;
// }

// Console.WriteLine ("Введите номер четверти");
// int num = Convert.ToInt32 (Console.ReadLine());
// if (num ==1)
// {
//    Console.WriteLine ("X > 0,Y > 0");
// }
// else if (num == 2)
// {
//    Console.WriteLine ("X < 0,Y > 0");
// }
// else if (num == 3)
// {
//    Console.WriteLine ("X < 0,Y < 0");
// }
// else if (num == 4)
// {
//    Console.WriteLine ("X > 0,Y < 0");
// }
// else 
// {
// Console.WriteLine ("некорректно");
// }
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine ("Enter x1: ");
// int Xa = Int16.Parse(Console.ReadLine());

// Console.WriteLine ("Enter y1: ");
// int Ya = Int16.Parse(Console.ReadLine());

// Console.WriteLine ("Enter x2: ");
// int Xb = Int16.Parse(Console.ReadLine());

// Console.WriteLine ("Enter y2: ");
// int Yb = Int16.Parse(Console.ReadLine());

// double AC = (Xb - Xa);
// double BC = (Yb - Ya);

// double AB = Math.Pow(AC, 2) + Math.Pow(BC, 2);

// double result = Math.Sqrt(AB);

// Console.WriteLine(result);

// Console.WriteLine ("Enter N: ");
// int N = int.Parse(Console.ReadLine());
// int i = 1;
// double sqr = 1;
// while (N >= i)
// {
//     sqr = Math.Pow(i, 2);
//    Console.Write($"{sqr}, ");
//    i++;
// }
//1
// void Method1()
// {
//    Console.WriteLine("Автор ...");
// }
// Method1();

//2
// void Method2(string msg)
// {
//    Console.WriteLine(msg);
// }
// //Method2(msg: "текст сообщения..");

// void Method21(string msg, int count)
// {
//    int i = 0;
//    while (i < count)
//    {
//       Console.WriteLine(msg);
//       i++;
//    }
// }
// Method21(msg:"Текст",count: 4);

//3 
// int Method3()
// {
//    return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//4
// string Method4(int count, string c)
// {
//    int i = 0;
//    string result = String.Empty;
//    while (i < count)
//    {
//       result = result + c;
//       i++;
//    }
//    return result;
// }
// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

// string Method4(int count, string c)
// {
//    string result = String.Empty;
//    for (int i = 0; i < count; i++)
//    {
//       result = result + c;
//          }
//    return result;
// }
// string res = Method4(2, "qwerty");
// //Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//    for (int j = 0; j <= 10; j++)
//    {
//       Console.WriteLine($"{i}*{j} = {i*j}");
//    }
//    Console.WriteLine();
// }

// string text = "- Я думаю, - сказал князь, улыбаясь, что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// //string s = "qwerty'
// //            012
// //s[3]        r     

// string Replace(string text, char oldValue, char newValue)
// {
//    string result = String.Empty;
   
//    int lenght = text.Length;
//    for (int i = 0; i < lenght; i++)
//    {
//       if(text[i] == oldValue) result = result + $"{newValue}";
//       else result = result + $"{text[i]}";
//    }
//    return result;
// }
// string newText = Replace(text,' ' , '|' );
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text,'к' , 'К' );
// Console.WriteLine(newText);


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
   int count = array.Length;
for (int i = 0; i < count; i++)
{
   Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
   for (int i = 0; i < array.Length - 1; i++)
   {
      int minPosition = i;
      for (int j = i+1; j < array.Length; j++)
      {
        if(array[j] < array[minPosition]) minPosition = j;
      }
      int temporary = array[i];
      array[i] = array[minPosition];
      array[minPosition] = temporary;
   }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);