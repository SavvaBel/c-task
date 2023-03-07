﻿// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int x = int.Parse (Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = int.Parse (Console.ReadLine());
// if (x > y)
// {
//     Console.WriteLine("max = первое число");
// }
// else
// {
//     Console.WriteLine("max = второе число");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.Write("Введите первое число: ");
// int x = int.Parse (Console.ReadLine());
// Console.Write("Введите второе число: ");
// int y = int.Parse (Console.ReadLine());
// Console.Write("Введите третье число: ");
// int z = int.Parse (Console.ReadLine());
// int max = x;

// if (x > max ) max = x;
// if (y > max ) max = y;
// if (z > max ) max = z;

// Console.Write("max = ");
// Console.WriteLine(max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int x = int.Parse (Console.ReadLine());
// if (x%2 == 0)
// {
//     Console.WriteLine("число четное");
// }
// else
// {
//     Console.WriteLine("число нечетное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8



// Console.Write("Введите число: ");
// int x = int.Parse (Console.ReadLine()!);
// if (x == 5)
// {
//     Console.WriteLine("2,4");
// }
// if (x == 8)
// {
//     Console.WriteLine("2,4,6,8");
// }






// Д.з. второго семинара


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int A = number % 100 / 10;  // показавает 2 число
// Console.WriteLine(A);   

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int number = new Random().Next(10, 1000);
// Console.WriteLine(number);

// int A = number % 10;  // показавает 3 число
// if(number > 99)
// {
// Console.WriteLine(A);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите число от 1-7, где 1-5 будние дни; 6-7 выходные: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number == 1) {
// System.Console.WriteLine("нет, будний");
// }if (number == 2) {
// System.Console.WriteLine("нет, будний");
// }
// if (number == 3)
// {
// System.Console.WriteLine("нет, будний");
// }
// if (number == 4)
// {
// System.Console.WriteLine("нет, будний");
// }
// if (number == 5)
// {
// System.Console.WriteLine("нет, будний");
// }
// if (number == 6)
// {
// System.Console.WriteLine("да, выходной");
// }
// if (number == 7)
// {
// System.Console.WriteLine("да, выходной");
// }

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет

// 12821 -> да

// 23432 -> да


// namespace CA_9
// {
//     class Program
//     {
 
//         static void Main(string[] args)
//         {
//             int num = int.Parse(Console.ReadLine());
//             Console.WriteLine(IsPalindrome(num));
//             Console.ReadKey(true);
//         }
        
//         static bool IsPalindrome(int num)
//         {
//             if (num >= 0 && num <10)
//                 return true;
//             int numLength = GetLength(num);
//             int[] digits = new int[numLength];
//             for (int i = numLength - 1; i >= 0; i--) {
//                 digits[i] = num % 10;
//                 num /= 10;
//             }
//             for (int i = 0; i < numLength/2; i++) {
//                 if (digits[i] != digits[numLength - i - 1])
//                     return false;
//             }
//             return true;
//         }
        
//         static int GetLength(int num)
//         {
//             int n = 0;
//             while (num > 0) {
//                 num /= 10;
//                 n++;
//             }
//             return n;
//         }
//     }
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите координаты Х1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты У1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты z1: ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Х2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты У2: ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты z2: ");
// int z2 = int.Parse(Console.ReadLine());
// int A = (x2-x1)*(x2-x1);
// int B = (y2-y1)*(y2-y1);
// int C = (z2-z1)*(z2-z1);
// double AB = Math.Sqrt(A+B+C);
// Console.Write(AB);


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int x = 1;
// while (x <= N)
// {
//     int y = x*x*x;
//     Console.WriteLine(y);
//     x++;
// }