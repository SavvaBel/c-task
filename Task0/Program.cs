// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.Write("Введите число: ");
// int number = int.Parse (Console.ReadLine());
// int sqr = number*number;
// Console.WriteLine("Квадрат числа " + number + "равен = " + sqr);

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите число 1: ");
// int x = int.Parse (Console.ReadLine());
// Console.Write("Введите число 2: ");
// int y = int.Parse (Console.ReadLine());
// int sqr = y*y;
// if(sqr == x)
// {
//     Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадротом второго");
// }


Console.Write("Введите число от 1-7: ");
int number = int.Parse(Console.ReadLine());
if (number == 1) {

System.Console.WriteLine("Понедельник");
}
if (number == 2) {

System.Console.WriteLine("Вторник");
}
if (number == 3)
{

System.Console.WriteLine("Среда");
}
if (number == 4)
{

System.Console.WriteLine("Четверг");
}
if (number == 5)
{

System.Console.WriteLine("Пятница");
}
if (number == 6)
{

System.Console.WriteLine("Суббота");
}
if (number == 7)
{

System.Console.WriteLine("Воскресенье");
}