// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.Write("Введите трёхзначное число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// if(((number3 / 100) > 0) && ((number3 / 1000) < 1) ){
// string stringNumber = Convert.ToString(number3);
// Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
// }
// else{
//     System.Console.WriteLine("Число не трехзначное");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(((number / 100) > 0) && ((number / 1000) < 1) ){
int lastNumber = number % 10;
System.Console.WriteLine( "Последняя цифра: "+ lastNumber);
}
else{
    System.Console.WriteLine("Число не трехзначное");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// void CheckingTheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("(этот день выходной) -> да");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("это вообще не день недели");
//   }
//   else Console.WriteLine("(этот день не выходной) -> нет");
// }
// CheckingTheDayOfTheWeek(dayNumber);