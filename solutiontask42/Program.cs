﻿// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11

Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()),2)); // Длинные строки всегда читаем изнутри 

int number = int.Parse(Console.ReadLine());         // Вводим переменную и считываем значение с консоли
string outLine = Convert.ToString(number,2);        // С помощью конвертора переводим число в дыоичную систему и преобразуем ее в строку
Console.WriteLine(outLine);                         // Выводим на консоль полученное значение