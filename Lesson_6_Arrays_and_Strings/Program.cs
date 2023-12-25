// // /Пример
// // [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

Console.Clear();
// char[] array = new char[]{'a', 'b', 'c'};
// string res = "";
// // for(int i = 0; i < array.Length; i++)
// //     res += array[i];

// foreach(char i in array)
//     res += i;

// Console.WriteLine(res);

// ----------------------------------------------------------------------------------------
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

// string str = "Hello";
// char[] array = new char[str.Length];
// for (int i = 0; i < array.Length; i++)
//     array[i] = str[i];

// Console.WriteLine($"'{str}' => [{string.Join(", ", array)}]");

// string name = "Rustem";
// int age = 50;
// string city = "Krasnodar";
// Console.WriteLine("Меня зовут " + name + ", мне " + age + " лет. Я из города " + city + ".");
// Console.WriteLine($"Меня зовут {name}, мне {age} лет. Я из города {city}.");



// ------------------------------------------------------------------------------------------------------------------------
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

Console.Write("Введите строку: ");
string str = Console.ReadLine().ToLower();
string vol = "eioau";
int count = 0;

foreach(char i in str)
    if (vol.Contains(i))
        count += 1;

Console.WriteLine($"\"{str}\" => {count}");
