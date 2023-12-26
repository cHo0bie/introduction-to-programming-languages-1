// Задача 1: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// class Program
// {
//     static void Main()
//     {
//         int num_M = 1;
//         int num_N = 100;

//         PrintNums(num_M, num_N);
//     }

//     static void PrintNums(int num_M, int num_N)
//     {
//         if (num_M > num_N)
//             return;
        
//         Console.WriteLine(num_M);
//         PrintNums(num_M + 1, num_N);
//     }
// }

//===========================================================

// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.


// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = { 1, 2, 3, 4, 5 };
//         PrintReverse(array, array.Length - 1);
//     }

//     static void PrintReverse(int[] array, int index)
//     {
//         if (index < 0)
//         {
//             return;
//         }

//         Console.WriteLine(array[index]);
//         PrintReverse(array, index - 1);
//     }
// } 

//==========================================================

// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

namespace AckermannFunction
{
    class Program
    {
        static int Ackermann(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return Ackermann(m - 1, 1);
            else
                return Ackermann(m - 1, Ackermann(m, n - 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите не отрицательное число m и n для функции Аккермана:");
            Console.Write("m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            int result = Ackermann(m, n);
            Console.WriteLine($"Результат вычисления функции Аккермана A({m}, {n}) = {result}");
        }
    }
}