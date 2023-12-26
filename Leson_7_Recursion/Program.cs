/*Напишите программу, которая будет принимать
 на вход число и возвращать сумму его цифр. 
 Указание Использовать рекурсию.
*/

// int number = Convert.ToInt32(Console.ReadLine());

// int sumOfDigits(int num)
// {
//     if(num < 10)
//         return num;

//     int sum = (num % 10) + sumOfDigits(num / 10);
    
//     return sum;
// }

// // Console.WriteLine(sumOfDigits(number));

// /*Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// */

// Console.Write("Введите число: ");
// int upper = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(IterateAndPrint(1, upper));

// string IterateAndPrint(int start, int end)
// {
//     if(start == end)
//         return start.ToString();
//     return $"{start} {IterateAndPrint(++start, end)}";
// }

// /*int IterateAndPrint(int num)
// {
//     if(num <= 1)
//         return num;

//     Console.Write(IterateAndPrint(--num));
//     return num+1;
// }*/


// /*Напишите программу, которая на вход 
// принимает два числа A и B, и возводит число А 
// в целую степень B с помощью рекурсии.
// */
// using System.Runtime.Intrinsics.Arm;

// System.Console.WriteLine("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число В: ");
// int rank = Convert.ToInt32(Console.ReadLine());

// int Pow(int number, int rank)
// {
//     if(rank == 0)
//         return 1;
//     if(rank == 1)
//         return number;
//     return number * Pow(number, --rank);
// }

// System.Console.WriteLine(Pow(number, rank));

