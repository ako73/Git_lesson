﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// System.Console.Write("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if( number1 > number2)
// {
// Console.WriteLine( "Первое число больше второго");
// }
// else
// {
// Console.WriteLine( "Второе число больше первого");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// System.Console.Write(" Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число 3: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if( number1 > number2 && number1 > number3)
// {
// Console.WriteLine( number1 );
// }
// else if( number2 > number1 && number2 > number3)
// {
// Console.WriteLine( number2 );
// }
// else
// {
// Console.WriteLine( number3);
// }


// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет
// System.Console.Write("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
// System.Console.WriteLine("Число чётное");
// }
// else
// {
// System.Console.WriteLine("Число нечётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// System.Console.Write("Введит число");
// int number = Convert.ToInt32(Console.ReadLine());
// int step = 0;
// while ((step < number) && (step < (number - 2)))
// {
// step += 2;
// System.Console.Write($"{step}," );
// }
// if ( step == (number-2) )
// {
// System.Console.Write(step+2);
// }