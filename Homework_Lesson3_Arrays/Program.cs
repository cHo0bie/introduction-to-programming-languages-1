// Задача 1: Задайте одномерный массив из 10 целых чисел 
//от 1 до 100. Найдите количество элементов массива, 
//значения которых лежат в отрезке [20,90].

// Console.Clear();

// int[] arr = new int [10];
//             Random random = new Random();
//             int count = 0;

//             for (int i = 0; i < 10; i++)
//             {
//                 arr[i] = random.Next(1, 101);
//                 if (arr[i] >= 20 && arr[i] <= 90)
//                 {
//                     count++;
//                 }
//             }

// Console.WriteLine(String.Join(", ", arr));
// Console.WriteLine(count);

//==========================================================

//Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество 
// чётных чисел в массиве.

namespace EvenNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [10];
            Random random = new Random();
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(1, 101);
                if (array[i] >= 20 && array[i] <= 90)
                {
                    count++;
                }
            }
Console.WriteLine(String.Join(", ", array));
            int evenCount = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }

Console.WriteLine($"Колличество четных чисел:  {evenCount}");
        }
    }
}