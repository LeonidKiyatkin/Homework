//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//int SetNumber(string numberName)


// Console.WriteLine($"Enter number : ");
//      int num = Convert.ToInt32(Console.ReadLine());
  
// int numPalindrome = SetNumber("Palindrome");

// bool isPalindrome = IsPalindromeInt(numPalindrome);

// // bool isPalindrome = IsPalindromeString(numPalindrome.ToString());

// string str = isPalindrome ? "является палиндромом" : "не является палиндромом";

// if (isPalindrome)
// {
//     str = "является палиндромом";
// }
// else
// {
//     str = "не является палиндромом";
// }
// System.Console.WriteLine($"число {numPalindrome} {str}");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// int x1 = SetNumber("x1");
// int y1 = SetNumber("y1");
// int z1 = SetNumber("z1");
// int x2 = SetNumber("x2");
// int y2 = SetNumber("y2");
// int z2 = SetNumber("z2");

// double result = DistanceBetween3DPoints(x1, x2, y1, y2, z1, z2);

// System.Console.WriteLine($"result {result}");


// Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3-> 1, 8, 27
// 5-> 1, 8, 27, 64, 125
int num = SetNumber("N");

int[] arr = CubeTable(num);

System.Console.WriteLine(String.Join(",", arr));

int[] CubeTable(int n)
{
    int[] arr = new int[n];

    for (int i = 1; i <= n; i++)
    {
        arr[i - 1] = i * i * i;
    }

    return arr;
}




