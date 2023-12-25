// Задача 1: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.

// namespace GetElementFrom2DArray
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Создали массив.
//             int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//             Console.Write("Введите строку элемента: ");
//             int row = int.Parse(Console.ReadLine());
//             Console.Write("Введите столбец элемента: ");
//             int column = int.Parse(Console.ReadLine());

//             int element = GetElementFrom2DArray(array, row, column);

//             // Выводим информацию в консоль
//             if (element != -1)
//             {
//                 Console.WriteLine($"Элемент ({row}, {column}) находиться на позиции: {element}");
//             }
//             else
//             {
//                 Console.WriteLine("Данного элемента нет.");
//             }
//         }

//         static int GetElementFrom2DArray(int[,] array, int row, int column)
//         {
//             // Проверяем, находится ли позиция в пределах массива.
//             if (row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1))
//             {
//                 return -1;
//             }

//             // Возвращаем элемент в указанную позицию.
//             return array[row, column];
//         }
//     }
// }


//=======================================================================

// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.


using System;

namespace MinSumRow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание прямоугольного двумерного массива
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            // Нахождение строки с наименьшей суммой элементов
            int minSumRow = 0;
            int minSum = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                if (sum < minSum)
                {
                    minSum = sum;
                    minSumRow = i;
                }
            }

            // Вывод строки с наименьшей суммой элементов
            Console.WriteLine("Строка с наименьшей суммой элементов:");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[minSumRow, j] + " ");
            }
            Console.WriteLine();
        }
    }
}