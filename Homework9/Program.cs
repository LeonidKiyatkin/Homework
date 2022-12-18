// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int n = InputNumbers("Введите n: ");
int count = 1;
PrintNumber(n, count);
Console.WriteLine();



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputM(string M)
{
    Console.Write(M);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int InputN(string N)
{
    Console.Write(N);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void Sum(int M, int N)
{
    int sum = 0;
    if (M <= N)
    {
        while (M <= N)
        {
            sum = sum + M;
            M++;
        }
        Console.Write(sum);
    }
    else 
    {
        Console.WriteLine ("Операция невозможна");
    }    
}



int M = InputM("Введите M: ");
int N = InputN("Введите N: ");
Sum(M, N);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputM(string M)
{
    Console.Write(M);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int InputN(string N)
{
    Console.Write(N);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}



int M = InputM("Введите M: ");
int N = InputN("Введите N: ");
AkkermanFunction(M, N);
