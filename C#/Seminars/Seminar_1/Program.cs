//Напишите программу, которая на вход 
//принимает число и выдает его квардат (число
//умноженное само на себя)
// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());//covert переводит string в другую переменную

// int value = number * number;

// Console.Write("Результат: ");

// System.Console.WriteLine(value);

//2. Напишите программу, которая берет 2 числа 
//и проверяет является ли первое квадратом второго
//Решение:
// 1.ввод первого числа
// 2. ввод второго числа
// 3. проверяем первое число == второе * второе
// 4. если да, то пишем да
// 5. если нет, то пишем нет
System.Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int value = number2 * number2;
if  (value == number1) {
    System.Console.WriteLine("Да");
}

else {
    System.Console.WriteLine("Нет");
}

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// Решение:
//1. вводим число
//2. проверяем соответвие условию число >=1 и <=7
//3. switch(number){
// Case 1:
// System.Console.WriteLine(Понедельник);
// break;
// Case 2:
// System.Console.WriteLine(Вторник);
// break;
// //и т.д.
// default: System.Console.WriteLine(Bad number); break;
// }
// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// Console.Write("Enter number : ");

// int number = Convert.ToInt32(Console.ReadLine());

// int number2 = - number;
// int number2 = number * (-1);
// while(number2 <= number){

// // Console.Write($"{number2},");
// Console.Write(number2 + ",");

// ++number2;

// }


// Итерация №2
// Решение в группах задач: 20 мин
// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

