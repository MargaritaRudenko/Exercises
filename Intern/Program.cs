// // 0. Вывести квадрат числа

// int f(int x)
// {
//     return x*x;
// }

// int x=10;
// int res = f(x); Console.WriteLine(res);
// или
// res = f(5); Console.WriteLine(res);


// 1. По двум введённым числам проверять является ли первое квадратом второго

// string Sqrt(int a, int b)
// {
//     if(a == b*b) return ($"Число {a} является квадратом числа {b}");
//     return ($"Число {a} не является квадратом числа {b}");
// }
// Console.WriteLine(Sqrt(25, 5));


// bool Sqrt(int a, int b)
// {
//     return (a == b*b);
// }
// Console.WriteLine(Sqrt(4, 5));


// void Sqrt(int a, int b)
// {

//     if(a == b*b) Console.WriteLine($"Число {a} является квадратом числа {b}");
//     else Console.WriteLine($"Число {a} не является квадратом числа {b}");
// }
// Sqrt(a, b);


//  2. Даны два числа. Показать большее и меньшее число

// string Max(int a, int b)
// {
//     if (a>b) return ($"Max = {a}, min = {b}");
//     else return ($"Max = {b}, min = {a}");
// }

// int a = 8;
// int b = 15;
// Console.WriteLine(Max(a, b));


//  3. По введенному номеру дня недели вывести его название

// string WeekDay(int current)
// {
//     string[] week = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
//     string day = week[current-1];
//     return ($"Сегодня {day}");
// }
// int index = 4;
// Console.WriteLine(WeekDay(index));


//  4. Найти максимальное из трех чисел

// int Max(int a, int b, int c)
// {
//     int max = a;
//     if (b>max) max = b;
//     if (c>max) max = c;
//     return max;
// }
// int a = 6;
// int b = 13;
// int c = 9;
// Console.WriteLine($"Максимальное число {Max (a, b, c)}");


//  5. Написать программу вычисления значения функции y=f(a)

// double Sin(double degrees)
// {
//     double angle = Math.PI * degrees / 180.0;
//     return Math.Sin(angle);
// }
// double a = 1;
// Console.WriteLine($"синус {a} = {Sin(a)}");


//  6. Выяснить является ли число чётным

// string result (int number)
// {
//     if (number % 2 == 0) return ($"{number} - четное число");
//     else return ($"{number} - нечетное число");
// }
// string res = result (new Random().Next());
// Console.WriteLine(res);


// bool result (int number)
// {
//     return (number % 2 == 0);
// }
// int number = new Random().Next();
// Console.WriteLine(number);
// bool res = result (number);
// Console.WriteLine(res);

//  7. Показать числа от -N до N

// int Row (int N)
// {
//     int i = -N;
//     for (int index = -N; index <= N; index++)
//     {
//         Console.WriteLine(index);
//     }
//     return i;
// }
// Row(4);

// void Row (int N)
// {
//     for (int i = -N; i <= N; i++)
//     {
//         Console.Write($"{i} ");
//     }
// }
// Row(6);


//  8. Показать четные числа от 1 до N

// int Row(int N)
// {
//     int i = 1;
//     while (i <= N)
//     {
//         if (i % 2 == 0) Console.Write($"{i} ");
//         i++;
//     }
//     return i;
// }
// Row(10);


// void Row(int N)
// {
//     for (int i = 1; i <= N; i++)
//     {
//         if (i % 2 == 0) Console.Write($"{i} ");
//     }
// }
// Row(10);

//  9. Показать последнюю цифру трёхзначного числа

// int lastNum (int num)
// {
//     return num % 10;
// }

// int num = 123;
// Console.WriteLine($"Третья цифра цисла {num}: " + lastNum(num));


// 10. Показать вторую цифру трёхзначного числа

// int secondNum (int num)
// {
//     return (num / 10) % 10;
// }

// int num = 469;
// Console.WriteLine($"Вторая цифра цисла {num}: " + secondNum(num));


// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int maxNumber (int number)
// {
//     int numberOne = number / 10;
//     int numberTwo = number % 10;

//     if (numberOne>numberTwo) return numberOne;
//     else return numberTwo;
// }

// int num = new Random().Next(10, 100);
// Console.WriteLine($"В числе {num} наибольшая цифра {maxNumber(num)}");

// Решение через массив:

// char maxNumber (char[] number)
// {
//     if (number[0]>number[1]) return number[0];
//     else return number[1];
// }
// int i = new Random().Next(10, 100);
// char[] arr = i.ToString().ToCharArray();
// Console.WriteLine($"В числе {i} наибольшая цифра {maxNumber(arr)}");


// 12. Удалить вторую цифру трёхзначного числа

// string number (int a)
// {
//     int x = a / 100;
//     int z = a % 10;
//     return $"Получаем двузначное число {x}{z}";
// }
// int a = 500;
// Console.WriteLine(number(a));


// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// string result (int a, int b)
// {
//     if (a>=b) 
//     {
//         if (a % b == 0) return $"{a} кратно {b}";
//         return $"{a} не кратно {b}, остаток от деления равен {a % b}";
//     }
//     else 
//     {
//         if (b % a == 0) return $"{b} кратно {a}";
//         return $"{b} не кратно {a}, остаток от деления равен {b % a}";
//     }
// }
// Console.WriteLine(result(16, 16));


// 14. Найти третью цифру числа или сообщить, что её нет

// string num (string number)
// {
//     if (number.Length > 2) return $"Третья цифра в числе {number} - {number[2]}";
//     else return "В числе нет третьей цифры"; 
// }
// string number = Console.ReadLine();
// Console.WriteLine(num(number));


