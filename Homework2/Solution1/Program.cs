﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число, программа покажет вторую цифру этого числа.");
string number = Console.ReadLine();

char minus = ' ';
if (number[0] == '-'){
    number = number.Remove(0,1);
    minus = '-';
}
if (number.Length == 3){
    if (int.TryParse(number, out var input)){
        Console.WriteLine($"Вы ввели значение {minus}{input} . вторая цифра равна {input/10%10}");
    }
    else{
        Console.WriteLine("Вы не ввели трехзначное число.");
    }
}
else{
    Console.WriteLine("Вы не ввели трехзначное число.");
}
