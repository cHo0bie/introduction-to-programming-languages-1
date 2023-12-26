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


using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintReverse(array, array.Length - 1);
    }

    static void PrintReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(array[index]);
        PrintReverse(array, index - 1);
    }
} 