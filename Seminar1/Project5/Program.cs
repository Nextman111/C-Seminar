﻿ //Напишите программу,
 //которая принимает на вход трёхзначное число
 //и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Введите трехзначное число, программа покажет последнюю цифру этого числа");
Console.Write("Введите число ");
int a1 = int.Parse(Console.ReadLine());

Console.WriteLine($"последнее число равно {a1%10}");