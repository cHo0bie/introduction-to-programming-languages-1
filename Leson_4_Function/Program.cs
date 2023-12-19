using System.Text.RegularExpressions;

Console.Clear();
// void f(int a, int b)
// {
//     if (a > b)
//         Console.WriteLine(a);
//     else
//         Console.WriteLine(b);
// }

// f(6, 6);

// int f(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }

// // int x = f(8, 6);
// // Console.WriteLine(x);
// Console.WriteLine(f(8, 10));



// int n = 5;
// f(ref n);
// Console.WriteLine(n);

// void f(ref int n)
// {
//     Console.WriteLine(n);
//     n += 1;
//     Console.WriteLine(n);
// }


// --------------------------------------------------------------------------------------------
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3
// 8 -> 1 2 4 8
// 7 -> 1 7
// 15 -> 1 3 5 15
// 23 -> 1 23

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 20);
// }

// // функция возвращает True если число простое, иначе False
// bool CheckProst(int x)
// {
//     for (int j = 2; j < x; j++)
//         if (x % j == 0)
//             return false;
//     return true;
// }


// void ReleaseArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (CheckProst(array[i]))
//             count ++;
//     Console.WriteLine(count);
// }

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// ReleaseArray(array);


// --------------------------------------------------------------------------------------------------
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2




// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(19, 23);
// }

// // функция возвращает True если число простое, иначе False
// bool CheckProst(int x)
// {
//     if (x % 10 == 1 && x % 7 == 0)
//         return true;
//     else    
//         return false;
// }


// void ReleaseArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (CheckProst(array[i]))
//             count ++;
//     Console.WriteLine(count);
// }

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// ReleaseArray(array);



// ------------------------------------------------------------------------------------------------
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}

// 5 -> 57
// 7
// 5 * 10 + 7

void ReleaseArray(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
        res = res * 10 + array[i];
    Console.WriteLine(res);
}

// [5 4 6 8]
// 0
// 0 * 10 + 5 = 5
// 5 * 10 + 4 = 54
// 54 * 10 + 6 = 546
// 546 * 10 + 8 = 5468





Console.Clear();
Console.Write("Введите число элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine(string.Join(", ", array));
ReleaseArray(array);