
// итоговая работа 1
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void Print(int i) 
// {
//     if (i == 0)   
//     {
//         return;
//     }

//     Console.WriteLine(i); 

//     Print(i - 1);  
// }
// Print(5);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine ("введите M");
// int m = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine ("введите N");
// int n = Convert.ToInt32 (Console.ReadLine());
// int temp = m;

// if (m > n) 
// {
//   m = n; 
//   n = temp;
// }

// PrintSumm(m, n, 0);

// void PrintSumm(int m, int n, int summ)
// {
//   summ = summ + n;
//   if (n <= m)
//   {
//     Console.Write($"Сумма элементов= {summ} ");
//     return;
//   }
//   PrintSumm(n, n - 1, summ);
// }
// int summ = 0;
// for (int i = n; i >= m; i--)
// {
//     summ = summ + i;
// }
// Console.Write($"Сумма элементов= {summ} ");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine ("введите M");
// int m = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine ("введите N");
// int n = Convert.ToInt32 (Console.ReadLine());
// static int A(int n, int m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return A(n - 1, 1);
//     else
//       return A(n - 1, A(n, m - 1));
// }
// Console.WriteLine (A(n,m));









