// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23

// bool Number (int num)
// {
// return (num % 7 == 0 && num % 23 == 0);
// }
// Console.WriteLine(Number(132));


// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

// bool Day (int num)
// {
//     return num > 5;
// }
// Console.WriteLine(Day(4));


// 17. По двум введённым числам проверять является ли одно квадратом другого

// string Sqrt (int a, int b)
// {
//     if (a == b*b) return ($"Число {a} является квадратом числа {b}");
//     if (b == a*a) return ($"Число {b} является квадратом числа {a}");
//     else return "Ни одно число не является квадратом другого";
// }

// int a = 225;
// int b = 5;
// string Sq = Sqrt(a, b);
// Console.WriteLine(Sq);


// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool func18 (bool x, bool y)
// {
//     return ((!(x || y)) == (!x && !y));
// }
// bool x = true;
// bool y = true;
// Console.WriteLine(func18(x, y));


// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// int func19 (int x, int y)
// {
//     int quarter = 4;
//     if (x>0 && y>0) quarter = 1;
//     if (x<0 && y>0) quarter = 2;
//     if (x<0 && y<0) quarter = 3;
//     return quarter;
// }
// Console.WriteLine(func19 (-1, -2));


// 20. Ввести номер четверти, показать диапазоны для возможных координат

// string func20 (int quarter)
// {
//     if (quarter == 1) return "Диапозон Х от 0 до бесконечности, диапозон у от 0 до бесконечности";
//     if (quarter == 2) return "Диапозон Х от - бесконечности до 0, диапозон у от 0 до бесконечности";
//     if (quarter == 3) return "Диапозон Х от - бесконечности до 0, диапозон у от - бесконечности до 0";
//     if (quarter == 4) return "Диапозон Х от 0 до бесконечности, диапозон у - бесконечности до 0";
//     return "Пользователь - банан";
// }
// Console.WriteLine(func20(Convert.ToInt32(Console.ReadLine())));


// 21. Программа проверяет пятизначное число на палиндром.

// bool number (string num)
// {
//     return num[0] == num[4] && num[1] == num[3];
// }
// string num = "23431";
// Console.WriteLine(number(num));


// 22. Найти расстояние между точками в пространстве 2D

// double DistanceAB (double xa, double ya, double xb, double yb)
// {
//     double AB = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya));
//     return AB;
// }
// Console.WriteLine(DistanceAB(0, 0, 0, 0));
// Console.WriteLine(DistanceAB(2, 4, 2, 6));
// Console.WriteLine(DistanceAB(12, 6, 32, 6));
// Console.WriteLine(DistanceAB(12, 16, 32, 6));

// 22. Найти расстояние между точками в пространстве 3D

// double DistanceAB (double xa, double ya, double za, double xb, double yb, double zb)
// {
//     double AB = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
//     return AB;
// }
// Console.WriteLine(DistanceAB(0, 0, 0, 0, 0, 0));
// Console.WriteLine(DistanceAB(1, 2, 3, -7, -2, 4));
