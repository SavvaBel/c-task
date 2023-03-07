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


// Console.Write("Введите число от 1-7: ");
// int number = int.Parse(Console.ReadLine()!);
// if (number == 1) {

// System.Console.WriteLine("Понедельник");
// }
// if (number == 2) {

// System.Console.WriteLine("Вторник");
// }
// if (number == 3)
// {

// System.Console.WriteLine("Среда");
// }
// if (number == 4)
// {

// System.Console.WriteLine("Четверг");
// }
// if (number == 5)
// {

// System.Console.WriteLine("Пятница");
// }
// if (number == 6)
// {

// System.Console.WriteLine("Суббота");
// }
// if (number == 7)
// {

// System.Console.WriteLine("Воскресенье");
// }


// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8



// int number = new Random().Next(10,100);
// int a1 = number / 10;
// int a2 = number % 10;
// if (a1>a2)
// {
//     Console.WriteLine(a1);
// }
// else
// {
//     Console.WriteLine(a2);
// }


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int number1 = number / 100;  // показавает 1 число
// Console.WriteLine(number1);
// int number2 = number % 100 / 10;  // показавает 2 число
// Console.WriteLine(number2);   
// int number3 = number % 10;  // показавает 3 число
// Console.WriteLine(number3);
// Console.WriteLine(number1 * 10 + number3);



// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int A = number / 100;  // показавает 1 число
// int B = number % 10;  // показавает 3 число
// Console.WriteLine(A * 10 + B);



// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


// Console.WriteLine("Введите первое число");
// int numberA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numberB = int.Parse(Console.ReadLine());
// int numberC = numberB % numberA;
// Console.WriteLine("Остаток от деления " + numberC);
// if (numberC == 0)
// {
// Console.WriteLine("Второе число является кратным первому ");
// }

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Ввести число ");
// int A = Convert.ToInt32(Console.ReadLine());
// if(A%7 == 0 && A%23 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Некратно");
// }


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
// Console.WriteLine("Ввести первое число ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ввести второе число ");
// int B = Convert.ToInt32(Console.ReadLine());
// if(A == B*B || B == A*A)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Некратно");
// }


// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите x: ");
// int x = int.Parse(Console.ReadLine());

// Console.Write("Введите y: ");
// int y = int.Parse(Console.ReadLine());

// if( x>0 && y>0 )
// {
//     Console.WriteLine("1");
// }
// if( x<0 && y>0 )
// {
//     Console.WriteLine("2");
// }if( x<0 && y<0 )
// {
//     Console.WriteLine("3");
// }if( x>0 && y<0 )
// {
//     Console.WriteLine("4");
// }



// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

// Console.Write("Введите четверть: ");

// int x = int.Parse(Console.ReadLine());
// if (x == 1)
// {
//     Console.WriteLine("Диапозон X от 0 до 5, диапозон Y от 0 до 5");
// }
// if (x == 2)
// {
//     Console.WriteLine("Диапозон X от 0 до -5, диапозон Y от 0 до 5");
// }
// if (x == 3)
// {
//     Console.WriteLine("Диапозон X от 0 до -5, диапозон Y от 0 до -5");
// }
// if (x == 4)
// {
//     Console.WriteLine("Диапозон X от 0 до 5, диапозон Y от 0 до -5");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координаты Х1: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты У1: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Х2: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты У2: ");
// int y2 = int.Parse(Console.ReadLine());
// int A = (x2-x1)*(x2-x1);
// int B = (y2-y1)*(y2-y1);
// double AB = Math.Sqrt(A+B);
// Console.Write(AB);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int x = 1;
// while (x <= N)
// {
//     int y = x*x;
//     Console.WriteLine(y);
//     x++;
// }


namespace CA_9
{
    class Program
    {
 
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPalindrome(num));
            Console.ReadKey(true);
        }
        
        static bool IsPalindrome(int num)
        {
            if (num >= 0 && num <10)
                return true;
            int numLength = GetLength(num);
            int[] digits = new int[numLength];
            for (int i = numLength - 1; i >= 0; i--) {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength/2; i++) {
                if (digits[i] != digits[numLength - i - 1])
                    return false;
            }
            return true;
        }
        
        static int GetLength(int num)
        {
            int n = 0;
            while (num > 0) {
                num /= 10;
                n++;
            }
            return n;
        }
    }
}