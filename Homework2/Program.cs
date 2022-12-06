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