﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length > 2)
{
        Console.WriteLine("Третья цифра цисла: " + number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}


