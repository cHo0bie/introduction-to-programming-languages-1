// Задача 1: Задайте одномерный массив из 10 целых чисел 
//от 1 до 100. Найдите количество элементов массива, 
//значения которых лежат в отрезке [20,90].

Console.Clear();

int[] arr = new int [10];
            Random random = new Random();
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                arr[i] = random.Next(1, 101);
                if (arr[i] >= 20 && arr[i] <= 90)
                {
                    count++;
                }
            }

Console.WriteLine(String.Join(", ", arr));
Console.WriteLine(count);