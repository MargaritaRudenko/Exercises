// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 


// 24. Найти кубы чисел от 1 до N


// 25. Найти сумму чисел от 1 до А

// int func25 (int n)
// {
//     n = n * (n+1)/ 2;
//     return n;
// }
// Console.Write(func25(3));


// 26. Возведите число А в натуральную степень B используя цикл

// int func26 (int A, int B)
// {
//     int result = 1;
//     for (int i = 1; i < B; i++) 
//     {
//         result = result * A;
//     } 
//     return result;
// }
// Console.WriteLine(func26(3, 4));


// 27. Определить количество цифр в числе

// int func27 (string a)
// {
//     int x = a.Length;
//     return x;
// }
// Console.WriteLine(func27("34567"));


// 28. Подсчитать сумму цифр в числе

// int func28(int N)
// {
//     int summ = 0;
//     while (N!=0)
//     {
//         summ = summ + N % 10;
//         N = N / 10;
//     }
//     return summ;
// }

// Console.WriteLine (func28(3478));

// N 12345  o  summ
//   1234   5  5
//   123    4  9
//   12     3  12
//   1      2  14
//   0      1  15



// 29. Написать программу вычисления произведения чисел от 1 до N

// int func29 (int N)
// {
//     int result = 1;
//     for (int i=1; i<=N; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }
// Console.WriteLine(func29(4));

// 30. Показать кубы чисел, заканчивающихся на четную цифру

// string value (int n){
//     string res = string.Empty;
//     int cb = 1;
//     for (int i = 0; i < n; i++)
//     {
//         if (cb % 2 == 0)
//         {
//             res = $"{res} {Math.Pow(cb, 3)}"; cb++;
//         }
//         else cb++;
//     }
//     return res;
// }
// Console.Write(value(10));
